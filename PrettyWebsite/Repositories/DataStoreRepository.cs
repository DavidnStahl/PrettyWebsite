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
        public void Save(ReviewData data)
        {
            DynamicDataStore store = typeof(ReviewData).GetOrCreateStore();
            store.Save(data);
        }

        public  List<ReviewData> Get(string id)
        {
            DynamicDataStore store = typeof(ReviewData).GetOrCreateStore();
            var reviewData = store.Items<ReviewData>().Where(data => data.MovieId == id)
                                                      .OrderByDescending(date => date.PubliationDate)
                                                      .ToList();
            return reviewData;
        }
    }
}
