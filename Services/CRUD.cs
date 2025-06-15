using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarApp.Data;
using CarApp.Models;
using Microsoft.Identity.Client;

namespace CarApp.Services
{
    public class CRUD
    {
        public void AddCar(Car car)
        {
            Records.carContext.Carset.Add(car); //Adding new car
            Records.carContext.SaveChanges();
        }

        public Car FindCar(int CarId)
        {
            return Records.carContext.Carset.Find(CarId); // Find car by Vin Number
        }

        public void DeleteCar(int CarId)
        {
            var c = Records.carContext.Carset.Find(CarId);
            if(c != null)
            {
                Records.carContext.Carset.Remove(c);// Remove the car
            }
            Records.carContext.SaveChanges();
        }

        public void UpdateCar(int CarId, Car updateCar)
        {
            var c = Records.carContext.Carset.Find(CarId);
            if (c != null)
            {
                c.CarPrice = updateCar.CarPrice;
                Records.carContext.SaveChanges();
            }
        }
        public List<Car> GetAllCars()
        {
            return Records.carContext.Carset.ToList(); // get all the car from database
        }

        public int GetMaxCarId()
        {
            return Records.carContext.Carset.Max(e => e.CarId); // Get max car Id
        }
    }
}
