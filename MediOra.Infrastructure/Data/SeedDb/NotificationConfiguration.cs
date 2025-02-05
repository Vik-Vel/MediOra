using MediOra.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediOra.Infrastructure.Data.SeedDb
{
    public class NotificationConfiguration : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            // Many-to-One relationship with IdentityUser
            builder.HasOne(n => n.User)                     // Notification is associated with one user
            .WithMany()                                     // IdentityUser does not have a collection of notifications
            .HasForeignKey(n => n.UserId)                   // Foreign Key in the Notification table
            .OnDelete(DeleteBehavior.Cascade);              // If the user is deleted, the notifications are deleted


            var data = new SeedData();

            builder.HasData(new Notification[] {data.Notification1, data.Notification2 });
        }
    }
}
