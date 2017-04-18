using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aquarium.Models;

namespace Aquarium.DataContext
{
    class AquariumContext : DbContext
    {
        public AquariumContext() : base() { }
        public DbSet<Oceans> Oceans { get; set; }
        public DbSet<Aquariums> Aquariums { get; set; }
        public DbSet<MarineLife> MarineLife { get; set; }
    }
}
