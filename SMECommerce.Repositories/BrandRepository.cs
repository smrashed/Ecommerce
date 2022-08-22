using Microsoft.EntityFrameworkCore;
using SMECommerce.Databases.DbContexts;
using SMECommerce.Models.EntityModels;
using SMECommerce.Repositories.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace SMECommerce.Repositories
{
    public class BrandRepository:Repository<Brand>, IBrandRepository
    {
        SMECommerceDbContext _db;
        public BrandRepository(SMECommerceDbContext db):base(db)
        {
            _db = db;
        }
        public override Brand GetById(int id)
        {
            return _db.Brands.FirstOrDefault(c => c.Id == id);
        }

        public override ICollection<Brand> GetAll()
        {
            return _db.Brands.Include(c => c.Products).ToList();
        }

        
    }
}


