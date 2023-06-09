﻿using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    class Program
    {
        static void Main(string[] args)
        {
            // SIN GENERIC
            //using (var context = new DesignPatternsContext())
            //{
            //    var beerRepository = new BeerRepository(context);
            //    var beer = new Models.Beer();
            //    beer.Name = "Corona";
            //    beer.Style = "Pilsner";
            //    beerRepository.Add(beer);
            //    //beerRepository.Save(); // Esta generando una excepcion el BrandId

            //    foreach (var b in beerRepository.Get())
            //    {
            //        Console.WriteLine(b.Name);
            //    }
            //}

            // CON GENERIC
            //using (var context = new DesignPatternsContext())
            //{
            //    var beerRepository = new Repository<Beer>(context);
            //    var beer = new Beer() { Name = "Fuller", Style = "Strong Ale" };
            //    beerRepository.Add(beer);
            //    //beerRepository.Save();

            //    foreach (var b in beerRepository.Get())
            //    {
            //        Console.WriteLine($"{b.BeerId} {b.Name}");
            //    }

            //}


            // UNIT OF WORK
            //using (var context = new DesignPatternsContext())
            //{
            //    var unitOfWork = new UnitOfWork(context);

            //    var beers = unitOfWork.Beers;
            //    var beer = new Beer()
            //    {
            //        Name = "Fuller",
            //        Style = "Porter"
            //    };

            //    beers.Add(beer);

            //    var brands = unitOfWork.Brands;
            //    var brand = new Brand()
            //    {
            //        Name = "Fuller"
            //    };

            //    brands.Add(brand);

            //    unitOfWork.Save();
            //}

            Console.ReadKey();
        }
    }
}
