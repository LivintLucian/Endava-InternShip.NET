using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Server.Models;

namespace Server.Data
{
    internal class RestaurantConfiguration : IEntityTypeConfiguration<RestaurantBranch>
    {
        public void Configure(EntityTypeBuilder<RestaurantBranch> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.City);
            builder.Property(e => e.PhoneNumber);
            builder.Property(e => e.Open);
            builder.Property(e => e.Street);

            builder.ToTable("Restaurants");
        }
    }
}