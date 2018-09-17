using Models.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Models.Configuration
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(30);

            Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(30);

            Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(30);

            Property(x => x.Username)
                .IsRequired()
                .HasMaxLength(30);

            Property(x => x.Password)
                .IsRequired()
                .HasMaxLength(30);

           
        }
    }
}
