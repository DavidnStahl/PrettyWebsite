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

        public void SaveRating(Identity id,string rating)
        {
            var reviewData = _store.Items<Review>().FirstOrDefault(data => data.Id == id);

            if(rating == "up")
            {
                reviewData.ReviewRating++;
            }
            else
            {
                reviewData.ReviewRating--;
            }

            _store.Save(reviewData);
        }

        public  List<Review> Get(string id)
        {
            var reviewData = _store.Items<Review>().Where(data => data.MovieId == id)
                                                  .OrderByDescending(data => data.ReviewRating)
                                                  .ToList();
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

        public void DeleteBadReview()
        {
            var reviewData = _store.Items<Review>().Where(data => data.ReviewRating < -5)
                                                  .ToList();

            foreach (var item in reviewData)
            {
                _store.Delete(item.Id);
            }

        }
    }
}
