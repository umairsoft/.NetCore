﻿using System;
using System.Collections.Generic;
using System.Text;
using CodeFirst.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
