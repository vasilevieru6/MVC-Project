using Models.Domain;
using System;
using System.Data.Entity.ModelConfiguration;

namespace Models.Configuration
{
    class OrderConfiguration : EntityTypeConfiguration<Order>
    {
        public OrderConfiguration()
        {
            Property(e => e.Status)
            .IsRequired();

            Property(x => x.Number)
                 .IsRequired()
                 .HasMaxLength(20);

            Property(x => x.Description)
                 .HasMaxLength(1000);

            Property(x => x.OrderDate)
                 .IsRequired();

            Property(x => x.TotalAmount)
                 .IsRequired();
        }

    }
}
