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
        void Save(ReviewData data);

        List<ReviewData> Get(string id);
    }
}
