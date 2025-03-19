using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MvcNetCoreChollometro.Models;

namespace MvcNetCoreChollometro.Data
{
    public class ChollometroContext : DbContext
    {
        public ChollometroContext(DbContextOptions<ChollometroContext> options) : base(options) { }
        public DbSet<Chollo> Chollos { get; set; }
    }
}
