using System;
using EPiServer.Data;
using EPiServer.Data.Dynamic;
using PrettyWebsite.DataStore;
using PrettyWebsite.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace PrettyWebsite.Repositories
{
    public class DataStoreRepository : IDataStoreRepository
    {
        private readonly DynamicDataStore _store = DynamicDataStoreFactory.Instance.CreateStore(typeof(Review));
        public void Save(Review data)
        {
            _store.Save(data);
        }

        public void SaveRating(Identity id, int rating)
        {
            var reviewData = _store.Items<Review>().FirstOrDefault(data => data.Id == id);

            if (reviewData == null) return;

            reviewData.ReviewRating += rating;

            _store.Save(reviewData);
        }

        public List<Review> GetFromMovieId(string id)
        {
            var reviewData = _store.Items<Review>().Where(data => data.MovieId == id)
                                                  .OrderByDescending(data => data.ReviewRating)
                                                  .ToList();
            return reviewData;
        }

        public List<Review> GetAll()
        {
            var reviewData = _store.Items<Review>().ToList();
            return reviewData;
        }

        public void Delete(string id)
        {
            var reviewData = _store.Items<Review>().Where(data => data.MovieId == id)
                                                  .ToList();

            foreach (var item in reviewData)
            {
                _store.Delete(item.Id);
            }

        }

        public void Delete(Guid externalId)
        {
            var identity = _store.Items<Review>().FirstOrDefault(r => r.Id.ExternalId == externalId);
            _store.Delete(identity);
        }

        public int DeleteBadReview()
        {
            var reviewData = _store.Items<Review>().Where(data => data.ReviewRating < -5)
                                                  .ToList();

            foreach (var item in reviewData)
            {
                _store.Delete(item.Id);
            }

            return reviewData.Count;
        }
    }
}
