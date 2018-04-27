using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WanderList.Models;

namespace WanderList.Models
{
    public class WanderListContext : DbContext
    {
        public WanderListContext (DbContextOptions<WanderListContext> options)
            : base(options)
        {
        }

        public DbSet<WanderList.Models.User> User { get; set; }
        public DbSet<WanderList.Models.Location> Location { get; set; }
		public DbSet<WanderList.Models.SavedLocation> SavedLocation { get; set; }
		public DbSet<WanderList.Models.ViewedLocation> ViewedLocation { get; set; }
	}
}
