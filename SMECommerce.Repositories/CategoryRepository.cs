using Microsoft.EntityFrameworkCore;
using SMECommerce.Databases.DbContexts;
using SMECommerce.Models.EntityModels;
using SMECommerce.Repositories.Abstractions;
using System.Collections.Generic;
using System.Linq;


namespace SMECommerce.Repositories
{
    public class CategoryRepository: Repository<Category>, ICategoryRepository
    {
        SMECommerceDbContext _db;
        public CategoryRepository(SMECommerceDbContext db):base(db)
        {
            _db = db;
        }
        public override Category GetById(int id)
        {
            return _db.Categories.FirstOrDefault(c => c.Id == id);
        }

        public override ICollection<Category> GetAll()
        {
            return _db.Categories.Include(c => c.Items).ToList();
        }
        

       
        public Category CategoryName(int id)
        {
            return _db.Categories.FirstOrDefault(c => c.Id == id);
        }
    }
}
