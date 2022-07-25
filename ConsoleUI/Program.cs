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

            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("Araba İsmi: " + car.CarName + " -- Araba Markası: " + car.BrandName + " -- Araba Rengi: " + car.ColorName + " -- Araba Fiyatı: " + car.DailyPrice);
                }
                Console.WriteLine(result.Message);
            }
            
            


        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car1 = new Car();
            car1.BrandId = 1;
            car1.ColorId = 1;
            car1.DailyPrice = 750000;
            car1.ModelYear = 2019;
            car1.Description = "Megane 4";

            var result1 = carManager.GetAll();

            Console.WriteLine("Tümü");
            if (result1.Success)
            {
                foreach (var car in result1.Data)
                {
                    Console.WriteLine(car.Description);
                }
                Console.WriteLine(result1.Message);
            }
            
            Console.WriteLine("*****************************************");
            Console.WriteLine("ID'si 1 olan");
            var result2 = carManager.GetCarById(1);
            if (result2.Success)
            {
                Console.WriteLine(result2.Data.Description);
            }
            
            var result3 = carManager.Add(car1);
            if (result3.Success)
            {
                Console.WriteLine(result3.Message);
            }
            else
            {
                Console.WriteLine(result3.Message);
            }
            

            //carManager.Delete(car1);

            //carManager.Update(car1);

        }
        /*
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



        }*/
    }
}
