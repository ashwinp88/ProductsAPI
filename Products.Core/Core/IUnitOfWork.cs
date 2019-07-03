using Products.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Core
{
    interface IUnitOfWork
    {
        IProductRepository Products { get; }
        int Complete();
    }
}
