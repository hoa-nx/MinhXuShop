using MinhXuShop.Data.Infrastructure;
using MinhXuShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhXuShop.Data.Repositories
{
    public interface IProductCategoryRepositpry : IRepository<ProductCategory>
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);

    }
    public class ProductCategoryRepositpry : RepositoryBase<ProductCategory> , IProductCategoryRepositpry

    {
        public ProductCategoryRepositpry(IDbFactory dbFactory) : base( dbFactory)
        {

        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
}
