using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogHouse.Model
{
    public class DogsDbContext: DbContext
    {
        public DogsDbContext() : base()
        {
        }
        public DbSet<Dog>Dogs { get; set; }
        public DbSet<Breed> Breeds { get; set; }
    }
}
