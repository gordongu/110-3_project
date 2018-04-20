using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WanderList.Models
{
    public class WanderListContext : DbContext
    {
        public WanderListContext (DbContextOptions<WanderListContext> options)
            : base(options)
        {
        }

        public DbSet<WanderList.Models.User> User { get; set; }
    }
}
