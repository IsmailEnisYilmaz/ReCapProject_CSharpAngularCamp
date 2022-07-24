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
            //CarTest();
            //BrandTest();
            //ColorTest();

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Araba İsmi: " + car.CarName + " -- Araba Markası: " + car.BrandName + " -- Araba Rengi: " + car.ColorName + " -- Araba Fiyatı: " + car.DailyPrice);
            }



        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car1 = new Car();
            car1.BrandId = 3;
            car1.ColorId = 3;
            car1.DailyPrice = 100100;
            car1.ModelYear = 2002;
            car1.Description = "Megane 1";

            Console.WriteLine("Tümü");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("*****************************************");
            Console.WriteLine("ID'si 1 olan");
            foreach (var car in carManager.GetCarsById(1))
            {
                Console.WriteLine(car.Description);
            }
            //carManager.Add(car1);
            //Console.WriteLine("Eklendi.");

            carManager.Delete(car1);
            Console.WriteLine("Silindi.");

            //carManager.Update(car1);
            //Console.WriteLine("Güncellendi.");

        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand1 = new Brand();
            brand1.BrandName = "Renault";
            

            Console.WriteLine("Tümü");
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
            Console.WriteLine("*****************************************");
            Console.WriteLine("ID'si 1 olan");
            foreach (var brand in brandManager.GetBrandsById(1))
            {
                Console.WriteLine(brand.BrandName);
            }
            brandManager.Add(brand1);
            Console.WriteLine("Eklendi.");
            Console.WriteLine("*****************************************");
            Console.WriteLine("Tümü");
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }



        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color color1 = new Color();
            color1.ColorName = "Lila";


            Console.WriteLine("Tümü");
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
            Console.WriteLine("*****************************************");
            Console.WriteLine("ID'si 1 olan");
            foreach (var color in colorManager.GetColorsById(1))
            {
                Console.WriteLine(color.ColorName);
            }
            colorManager.Add(color1);
            Console.WriteLine("Eklendi.");
            Console.WriteLine("*****************************************");
            Console.WriteLine("Tümü");
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }



        }
    }
}
