using Domain.Entities.Management;
using Domain.ValueObjects.Auth;
using Domain.ValueObjects.Management;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Context
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Seed data
        }

        public static void AddIdsForValueObjects(this ModelBuilder modelBuilder)
        {
            modelBuilder.AddIdsForUserRoles();
        }

        private static void AddIdsForUserRoles(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                    .HasConversion(
                        v => v.Value,
                        v => new UserId(v));

                entity.Property(e => e.RoleId)
                        .HasConversion(
                            v => v.Value,
                            v => new UserRolesId(v));  

            });
        }
    }
}
