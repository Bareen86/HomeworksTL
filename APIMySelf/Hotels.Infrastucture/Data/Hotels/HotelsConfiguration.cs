using Hotels.Domain.Hotels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotels.Infrastructure.Data.Hotels
{
    internal class HotelsConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.ToTable("Hotel");
            builder.HasMany(h => h.Rooms)
            .WithOne(r => r.Hotel)
            .HasForeignKey(r => r.HotelId)
            .OnDelete(DeleteBehavior.Cascade);
            
            builder.HasMany(h => h.Workers)
            .WithOne(w => w.Hotel)
            .HasForeignKey(w => w.HotelId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
