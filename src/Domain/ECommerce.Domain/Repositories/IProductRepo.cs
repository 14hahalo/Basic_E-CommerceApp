using ECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace ECommerce.Domain.Repositories
{
    public class IProductRepo : IBaseRepo<Product>
    {
        public Task<bool> Any(Expression<Func<Product, bool>> exception)
        {
            throw new NotImplementedException();
        }

        public Task Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetDefault(Expression<Func<Product, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetDefaults(Expression<Func<Product, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<TResult> GetFilteredFirstOrDefault<TResult>(Expression<Func<Product, TResult>> select, Expression<Func<Product, bool>> where, Func<IQueryable<Product>, IOrderedQueryable<Product>> orderBy = null, Func<IQueryable<Product>, IIncludableQueryable<Product, object>> include = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<TResult>> GetFilteredList<TResult>(Expression<Func<Product, TResult>> select, Expression<Func<Product, bool>> where, Func<IQueryable<Product>, IOrderedQueryable<Product>> orderBy = null, Func<IQueryable<Product>, IIncludableQueryable<Product, object>> include = null)
        {
            throw new NotImplementedException();
        }

        public Task Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
