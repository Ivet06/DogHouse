using DogHouseFramework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogHouseFramework.Controller
{
    public class BreedController
    {
        private DogDbContext _breedDbContext = new DogDbContext();

        //Породата
        public List<Breed> GetAllBreeds()
        {
            return _breedDbContext.Breeds.ToList();
        }
        //Метод за намиране на породата по id
        public string GetBreedsId(int id)
        {
            return _breedDbContext.Breeds.Find(id).Name;
        }
    }
}
