using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.DataAccess.Reposittory;
using Bulky.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly AppDbContext db;

        public CategoryRepository(AppDbContext db) : base(db)
        {
            this.db = db;
        }

        void ICategoryRepository.Update(Category category)
        {
            db.Categories.Update(category);
        }
    }
}
