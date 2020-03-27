using System;
using System.Collections.Generic;
using System.Text;

namespace ListAndLoopsExample
{
    class Coffee
    {
        public enum Roast
        {
            light = 1,
            lightmedium = 2,
            medium = 3,
            darkmedium = 4,
            dark = 5
        }
        
        public string brand;
        public decimal price;
        public Roast roast;
        public Company importer;

        public Coffee()
        {

        }

        public Coffee(string brand)
        {
            this.brand = brand;
        }

        public Coffee(string brand, decimal price, Roast roast, Company importer)
        {
            this.brand = brand;
            this.price = price;
            this.roast = roast;
            this.importer = importer;
        }
    }
}
