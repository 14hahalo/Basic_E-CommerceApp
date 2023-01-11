using ECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace ECommerce.Domain.Repositories
{
    public class ICategoryRepo : IBaseRepo<Category>
    {
        public Task<bool> Any(Expression<Func<Category, bool>> exception)
        {
            throw new NotImplementedException();
        }

        public Task Create(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetDefault(Expression<Func<Category, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetDefaults(Expression<Func<Category, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<TResult> GetFilteredFirstOrDefault<TResult>(Expression<Func<Category, TResult>> select, Expression<Func<Category, bool>> where, Func<IQueryable<Category>, IOrderedQueryable<Category>> orderBy = null, Func<IQueryable<Category>, IIncludableQueryable<Category, object>> include = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<TResult>> GetFilteredList<TResult>(Expression<Func<Category, TResult>> select, Expression<Func<Category, bool>> where, Func<IQueryable<Category>, IOrderedQueryable<Category>> orderBy = null, Func<IQueryable<Category>, IIncludableQueryable<Category, object>> include = null)
        {
            throw new NotImplementedException();
        }

        public Task Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
