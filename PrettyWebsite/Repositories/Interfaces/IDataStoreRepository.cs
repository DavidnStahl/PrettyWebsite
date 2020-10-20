using EPiServer.Data;
using PrettyWebsite.DataStore;
using System.Collections.Generic;

namespace PrettyWebsite.Repositories.Interfaces
{
    public interface IDataStoreRepository
    {
        void Save(Review data);

        List<Review> Get(string id);

        List<Review> GetAll();

        void Delete(string id);

        void SaveRating(Identity id, int rating);

        int DeleteBadReview();
    }
}
