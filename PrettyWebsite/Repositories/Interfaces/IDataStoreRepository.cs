using System;
using EPiServer.Data;
using PrettyWebsite.DataStore;
using System.Collections.Generic;

namespace PrettyWebsite.Repositories.Interfaces
{
    public interface IDataStoreRepository
    {
        void Save(Review data);

        List<Review> GetFromMovieId(string id);

        List<Review> GetAll();

        void Delete(string id);
        void Delete(Guid externalId);

        void SaveRating(Identity id, int rating);

        int DeleteBadReview();
    }
}
