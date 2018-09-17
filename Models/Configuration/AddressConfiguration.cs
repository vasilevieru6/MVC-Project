using Models.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Models.Configuration
{
    public class AddressConfiguration : EntityTypeConfiguration<Address>
    {
        public AddressConfiguration()
        {

            Property(x => x.Country)
                .HasMaxLength(50);

            Property(x => x.City)
                .IsRequired()
                .HasMaxLength(50);

            Property(x => x.Street)
                .IsRequired()
                .HasMaxLength(50);

            Property(x => x.PostalCode)
                .HasMaxLength(15);
        }
    }
}
