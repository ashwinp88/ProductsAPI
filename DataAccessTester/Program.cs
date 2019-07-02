using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace DataAccessTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new StoreDBEntities();
            var p = x.Products.Find(1);
            Console.WriteLine(p);
            Console.ReadLine();

        }
    }
}
