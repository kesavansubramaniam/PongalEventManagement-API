using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PongalEventManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PongalEventManagement.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
