using Models.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Models.Configuration
{
    public class ProductCharacteristicsConfiguration : EntityTypeConfiguration<ProductCharacteristics>
    {
        public ProductCharacteristicsConfiguration()
        {
            Property(x => x.Key)
                .IsRequired()
                .HasMaxLength(20);

            Property(x => x.Value)
                .IsRequired()
                .HasMaxLength(30);
        }
    }
}
