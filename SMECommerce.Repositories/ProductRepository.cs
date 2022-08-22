using Microsoft.EntityFrameworkCore;
using SMECommerce.Databases.DbContexts;
using SMECommerce.Models.EntityModels;
using SMECommerce.Repositories.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace SMECommerce.Repositories
{
    public class ProductRepository: Repository<Item>  ,IProductRepository
    {
        SMECommerceDbContext _db;
        public ProductRepository(SMECommerceDbContext db):base(db)
        {
           _db = db;
        }
        public override Item  GetById(int id)
        {
            return _db.Products.FirstOrDefault(c => c.Id == id);
        }
        public override ICollection<Item> GetAll()
        {
            return _db.Products.Include(c=>c.Category).ToList();
        }

        
    }
}
