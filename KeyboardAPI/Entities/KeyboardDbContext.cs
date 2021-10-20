using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeyboardAPI.Entities
{
    public class KeyboardDbContext: DbContext
    {
        public KeyboardDbContext(DbContextOptions <KeyboardDbContext> options): base(options)
        {               
        }

        public DbSet<KeyboardType> KeyboardTypes { get; set; }
    }
}
