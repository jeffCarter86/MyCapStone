﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RoadTrip.Models;

namespace RoadTrip.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Traveler> Travelers { get; set; }
      



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole
                    {
                        Name = "Traveler",
                        NormalizedName = "Traveler"
                    },
                    new IdentityRole
                    {
                        Name = "Agent",
                        NormalizedName = "Agent"
                    },
                    new IdentityRole
                    {
                        Name = "Operation",
                        NormalizedName = "Operation"
                    });
        }
    }
}
