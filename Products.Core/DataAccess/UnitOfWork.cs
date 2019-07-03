using Products.Core;
using Products.Core.Repositories;
using Products.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProductContext _context;

        public UnitOfWork(ProductContext context)
        {
            _context = context;
            Products = new ProductRepository(_context);
        }

        public IProductRepository Products { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
