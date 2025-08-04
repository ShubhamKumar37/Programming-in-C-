using Bulky.DataAccess.Repository.IRepository;
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
        void IRepository<Category>.Add(Category entity)
        {
            throw new NotImplementedException();
        }

        Category IRepository<Category>.Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Category> IRepository<Category>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IRepository<Category>.Remove(Category entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Category>.RemoveRange(IEnumerable<Category> entity)
        {
            throw new NotImplementedException();
        }

        void ICategoryRepository.Save()
        {
            throw new NotImplementedException();
        }

        void ICategoryRepository.Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
