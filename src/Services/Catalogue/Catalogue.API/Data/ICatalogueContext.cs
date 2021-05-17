using Catalogue.API.Entities;
using MongoDB.Driver;

namespace Catalogue.API.Data
{
    public class ICatalogueContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
