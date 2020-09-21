using EPiServer.Data;
using EPiServer.Data.Dynamic;
using PrettyWebsite.DataStore;
using PrettyWebsite.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyWebsite.Repositories
{
    public class DataStoreRepository : IDataStoreRepository
    {
        public void Save(Review data)
        {
            var store = DynamicDataStoreFactory.Instance.CreateStore(typeof(Review));
            store.Save(data);
        }

        public void SaveRating(Identity id,string rating)
        {
            var store = DynamicDataStoreFactory.Instance.CreateStore(typeof(Review));
            var reviewData = store.Items<Review>().FirstOrDefault(data => data.Id == id);

            if(rating == "up")
            {
                reviewData.ReviewRating++;
            }
            else
            {
                reviewData.ReviewRating--;
            }
            
            store.Save(reviewData);
        }

        public  List<Review> Get(string id)
        {
            var store = DynamicDataStoreFactory.Instance.CreateStore(typeof(Review));
            var reviewData = store.Items<Review>().Where(data => data.MovieId == id)
                                                  .OrderByDescending(data => data.ReviewRating)
                                                  .ToList();
            return reviewData;
        }

        public void Delete(string id)
        {
            var store = DynamicDataStoreFactory.Instance.CreateStore(typeof(Review));
            var reviewData = store.Items<Review>().Where(data => data.MovieId == id)
                                                  .ToList();

            foreach (var item in reviewData)
            {
                store.Delete(item.Id);
            }
            
        }
    }
}
