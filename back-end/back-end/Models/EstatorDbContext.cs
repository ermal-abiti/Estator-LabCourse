using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using back_end.Models;

namespace back_end.Models
{
    public class EstatorDbContext:DbContext

    {
        public EstatorDbContext(DbContextOptions<EstatorDbContext> options) : base(options) 
        {
                
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
    }


}
