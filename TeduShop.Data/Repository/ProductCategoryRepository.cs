using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repository
{
    interface IProductCategory : IRepository<ProductCategory>
    {
        IEnumerable<ProductCategory> GetListAllByAlias(string alias);
    }
   public class ProductCategoryRepository :RepositoryBase<ProductCategory>,IProductCategory
    {
        public ProductCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<ProductCategory> GetListAllByAlias(string alias)
        {
            return DbContext.ProductCategories.Where(x => x.Alias == alias).ToList();
        }
    }
}
