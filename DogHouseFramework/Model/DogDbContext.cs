using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DogHouseFramework.Model
{
    public class DogDbContext: DbContext
    {
        public DogDbContext() : base("DogDbContext")
        {
        }
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Breed> Breeds { get; set; }
    }
}
