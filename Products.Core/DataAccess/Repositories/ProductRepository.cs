using Products.Core.Domain;
using Products.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.DataAccess.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductContext ProductContext
        {
            get { return Context as ProductContext; }
        }
        public ProductRepository(ProductContext context) : base(context)
        {
        }

        public IEnumerable<Product> GetProducts(int pageIndex, int pageSize = 10)
        {
            return ProductContext.Products.Skip(pageIndex * pageSize).Take(pageSize);
        }
    }
}
