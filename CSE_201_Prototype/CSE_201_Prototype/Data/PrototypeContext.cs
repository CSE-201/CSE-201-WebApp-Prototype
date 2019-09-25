using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CSE_201_Prototype.Models;

namespace CSE_201_Prototype.Data
{
    public class PrototypeContext : DbContext
    {
        public PrototypeContext (DbContextOptions<PrototypeContext> options)
            : base(options)
        {
        }

        public DbSet<CSE_201_Prototype.Models.Software> Software { get; set; }
    
    }
}
