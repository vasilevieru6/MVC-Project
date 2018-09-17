using Models.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Models.Configuration
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(x => x.PhotoUrl)
                .IsRequired()
                .HasMaxLength(100);

            Property(x => x.Category)
                .IsRequired()
                .HasMaxLength(30);

            Property(x => x.SubCategory)
                .HasMaxLength(50);
            
        }
    }
}
