using System;
using System.Collections.Generic;
using System.Text;

namespace ListAndLoopsExample
{
    class DataHandler
    {
        public List<Coffee> coffees = new List<Coffee>();
        public List<Person> persons = new List<Person>();

        public Coffee CreateCoffee()
        {
            Console.WriteLine("Anna kahvin merkki");
            var merkki = Console.ReadLine();
            Coffee toReturn = new Coffee(merkki);
            return toReturn;
        }
    }
}
