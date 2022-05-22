using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { Id = 1, BrandId = 1, ColorId = "Bardak", ModelYear = 15, DailyPrice = 15, Description = "sadad" },
                new Car { Id = 2, BrandId = 1, ColorId = "Kamera", ModelYear = 500, DailyPrice = 3, Description = "asdad" },
                new Car { Id = 3, BrandId = 2, ColorId = "Telefon", ModelYear = 1500, DailyPrice = 2, Description = "dasdq" },
                new Car { Id = 4, BrandId = 2, ColorId = "Klavye", ModelYear = 150, DailyPrice = 65, Description = "qwddsa" },
                new Car { Id = 5, BrandId = 2, ColorId = "Fare", ModelYear = 85, DailyPrice = 11, Description = "dasdqwd" }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => car.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => car.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;

        }
    }
}
