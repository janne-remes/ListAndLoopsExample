using System;
using System.Collections.Generic;

namespace ListAndLoopsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var dh = new DataHandler();
            var kahvi = dh.CreateCoffee();
            dh.coffees.Add(kahvi);

            var paketti = new Coffee("Pressa", 3.4, Coffee.Roast.light, "Costa Rica");

            //var pakeTti1 = new Coffee("Juhlamokka");
            //var paketti2 = new Coffee("Presidentti");
            //var paketti3 = new Coffee("Pirkka");
            //var paketti4 = new Coffee("Brazil");

            //List<Coffee> coffees = new List<Coffee>();
            //coffees.Add(paketti1);
            //coffees.Add(paketti2);
            //coffees.Add(paketti3);
            //coffees.Add(paketti4);

            ////Console.WriteLine(coffees[0].brand);

            //foreach (Coffee item in coffees)
            //{
            //    Console.WriteLine($"Merkki: {item.brand}");
            //}

            //for (int i = 0; i < coffees.Count; i++)
            //{
            //    Console.WriteLine($"{i} Merkki: {coffees[i].brand}");
            //}

            ////Console.WriteLine(paketti.brand);
            ////Console.WriteLine(paketti2.brand);
            ////Console.WriteLine(paketti3.brand);
            ////Console.WriteLine(paketti4.brand);
        }
    }
}
