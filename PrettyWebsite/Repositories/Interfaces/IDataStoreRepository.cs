using PrettyWebsite.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyWebsite.Repositories.Interfaces
{
    public interface IDataStoreRepository
    {
        void Save(Review data);

        List<Review> Get(string id);

        void Delete(string id);
    }
}
