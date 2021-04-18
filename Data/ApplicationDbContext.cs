using Fantastical_Events_2021.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fantastical_Events_2021.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Event> Events { get; set; }

        public DbSet<Activity> Activities { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Cart> Carts { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Activity>()
                .HasOne(e => e.Event)
                .WithMany(a => a.Activities)
                //change the foreign key here to Event name instead of event id 
                //you dont need event id
                //idiot.
                .HasForeignKey(e => e.EventId)
                .HasConstraintName("FK_Activites_EventId");


            //Activity and Order Details 
            builder.Entity<OrderDetail>()
                 .HasOne(e => e.Activity)
                 .WithMany(a => a.OrderDetails)
                 .HasForeignKey(e => e.ActivityId)
                 .HasConstraintName("FK_OrderDetails_ActivityId");

            //Activity and Cart 
            builder.Entity<Cart>()
                .HasOne(e => e.Activity)
                .WithMany(a => a.Carts)
                .HasForeignKey(e => e.ActivityId)
                .HasConstraintName("FK_Carts_ActivityId");

            //Order and Order Detail 
            builder.Entity<OrderDetail>()
                 .HasOne(e => e.Order)
                 .WithMany(a => a.OrderDetails)
                 .HasForeignKey(e => e.OrderId)
                 .HasConstraintName("FK_OrderDetails_OrderId");


        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}
