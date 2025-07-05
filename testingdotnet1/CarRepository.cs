using System;
using System.Linq;

namespace CarProject //DO NOT Change the namespace name
{
    public class CarRepository //DO NOT Change the class name
    {
        public bool AddCar(Car car)
        {
            using (var context = new CarContext())
            {
                context.Cars.Add(car);
                return context.SaveChanges() > 0; // Return true if the car is added successfully
            }
        }
    }
} 