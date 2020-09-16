using EPiServer.Data;
using EPiServer.Data.Dynamic;
using System;

namespace PrettyWebsite.DataStore
{
    [EPiServerDataStore(AutomaticallyCreateStore = true, AutomaticallyRemapStore = true)]
    public class Review
    {
        public Identity Id { get; set; }


        public DateTime PubliationDate { get; set; }
        public string MovieId { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }

        public double Rating { get; set; }
    }
}