using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car1 = new Car();
            car1.CarId = 6;
            car1.BrandId = 3;
            car1.ColorId = 2;
            car1.DailyPrice = 800000;
            car1.ModelYear = 2021;
            car1.Description = "Audi";

            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("*****************************************");
            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine(car.Description);
            }

            carManager.Add(car1);

            Console.WriteLine("Bitti");

        }
    }
}
