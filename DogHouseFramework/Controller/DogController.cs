using DogHouseFramework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogHouseFramework.Controller
{
    public class DogController
    {
        private DogDbContext _dogsDbContext = new DogDbContext();
        
        //Метод за търсене на куче по id
        public Dog Get(int id)
        {
            Dog findedDog= _dogsDbContext.Dogs.Find(id);
            if (findedDog!=null)
            {
                _dogsDbContext.Entry(findedDog).Reference(x => x.Breeds).Load();
            }
            return findedDog;
        }

        //Метод който обединава кучето с породата
        public List<Dog> GetAll()
        {
            return _dogsDbContext.Dogs.Include("Breed").ToList();
        }

        //Създаване на куче
        public void Create(Dog dog)
        {
            _dogsDbContext.Dogs.Add(dog);
            _dogsDbContext.SaveChanges();
        }

        //Обновяване на кучето
        public void Update (int id, Dog dog)
        {
            Dog findedDog = _dogsDbContext.Dogs.Find(id);
            if (findedDog==null)
            {
                return; 
            }
            findedDog.Age= dog.Age;
            findedDog.Name= dog.Name;
            findedDog.BreedsId= dog.BreedsId;
            _dogsDbContext.SaveChanges();
        }

        //Изтриване на кучето 
        public void Delete(int id)
        {
            Dog findedDog = _dogsDbContext.Dogs.Find(id);
            _dogsDbContext.Dogs.Remove(findedDog);
            _dogsDbContext.SaveChanges();
        }
    }
}
