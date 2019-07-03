using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Products.Core.Domain;

namespace Products.DataAccess.EntityConfigurations
{
    class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            Property(p => p.Description)
                .IsRequired();

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
