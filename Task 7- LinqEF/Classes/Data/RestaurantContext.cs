using Server.Models;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace Server.Data
{
    public class RestaurantContext : DbContext
    {

        public RestaurantContext(DbContextOptions<RestaurantContext> options) 
            : base(options)
        {
        }

        //DbSet
        public static DbSet<RestaurantBranch> RestaurantBranches { get; set; }
        public static DbSet<EmployeeRequirements> EmployeesRequirements { get; set; }
        public static DbSet<OrderTable> ReservationsTables { get; set; }
        public static IList<JobApplication> JobApplications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            modelBuilder.ApplyConfiguration(new RestaurantConfiguration());
            modelBuilder.Entity<WaiterTable>()
                .HasKey(wt => new {wt.WaiterId, wt.TableID});

            modelBuilder.Entity<WaiterTable>()
                .HasOne(wt => wt.Waiter)
                .WithMany(w => w.WaiterTables)
                .HasForeignKey(wt => wt.WaiterId);

            modelBuilder.Entity<WaiterTable>()
                .HasOne(wt => wt.OrderTable)
                .WithMany(t => t.Waiters)
                .HasForeignKey(bc => bc.TableID);

            modelBuilder.Entity<RestaurantBranch>()
                .HasOne(m => m.Manager)
                .WithOne(rb => rb.RestaurantOwner)
                .HasForeignKey<Manager>(m => m.RestaurantId);
        }
    }
}