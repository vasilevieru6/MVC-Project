using Models.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Models.Configuration
{
    public class ShoppingCartConfiguration : EntityTypeConfiguration<ShoppingCart>
    {
        public ShoppingCartConfiguration()
        {
            Property(x => x.CreatedDate)
                .IsRequired();


            HasRequired(x => x.User)
                 .WithRequiredDependent(x => x.Cart);          
            
        }
    }
}
