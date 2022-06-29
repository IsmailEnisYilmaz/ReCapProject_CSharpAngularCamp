using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Console.WriteLine("************************Ekleyince Listele******************************");
            carManager.Add(new Car { Id = 4, BrandId = 5, ColorId = 6, DailyPrice = 450000, Description = "En İyisi Bu", ModelYear = 2020 });
            carManager.Add(new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 150000, Description = "En Kötüsü Bu", ModelYear = 2000 });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " " + car.Description + " " + car.DailyPrice);
            }
            Console.WriteLine("*********************Güncellendi***********************************");
            carManager.Update(new Car { Id = 4, BrandId = 5, ColorId = 6, DailyPrice = 450000, Description = "En İyisi ve Hızlısı Bu", ModelYear = 2020 });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " " + car.Description + " " + car.DailyPrice);
            }

            Console.WriteLine("************************ID'ye Göre Gelen******************************");

            foreach (var car in carManager.GetById(1))
            {
                Console.WriteLine(car.Id + " " + car.Description + " " + car.DailyPrice);
            }

            Console.WriteLine("************************Bir Tane silince Listele******************************");

            carManager.Delete(new Car { Id = 1 });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " " + car.Description + " " + car.DailyPrice);
            }

        }
    }
}
