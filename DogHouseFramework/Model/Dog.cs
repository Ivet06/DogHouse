using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogHouseFramework.Model
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public DateTime RegisterOn { get; set; }

        public int BreedsId { get; set; }
        public Breed Breeds { get; set; }
    }
}
