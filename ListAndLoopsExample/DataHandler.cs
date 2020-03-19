using System;
using System.Collections.Generic;
using System.Text;

namespace ListAndLoopsExample
{
    class DataHandler
    {
        //public List<Coffee> coffees = new List<Coffee>();
        public List<Person> persons = new List<Person>() {};

        //testidataa
        public void FillPersonsWithTestData()
        {
            this.persons.Add(new Person("Teppo", "Testaaja", "723 998 8213", "tepontestit@teppo.fi"));
            this.persons.Add(new Person("Karoliina", "Kokeilija", "567 951 1352", "karoliina@kokeilut.com"));
        }

        public Person CreatePerson()
        {
            Console.WriteLine("Anna etunimi.");
            string firstName = Console.ReadLine();
            Console.WriteLine("Anna sukunimi.");
            string lastName = Console.ReadLine();
            Console.WriteLine("Anna puhelinnumero.");
            string phone = Console.ReadLine();
            Console.WriteLine("Anna sähköposti.");
            string email = Console.ReadLine();

            Person person = new Person(firstName, lastName, phone, email);

            return person;
        }

        public void AddPersonToList()
        {
            var person = CreatePerson();
            this.persons.Add(person);
            Console.WriteLine("Henkilö lisätty listaan.");
        }

        public void PrintPersonList()
        {
            for(int i = 0; i < this.persons.Count; i++)
            {
                Console.WriteLine($"{i+1}. {this.persons[i].firstName} {this.persons[i].lastName}");
            }
        }

        /*public Coffee CreateCoffee()
        {
            Console.WriteLine("Anna kahvin merkki");
            var merkki = Console.ReadLine();
            Coffee toReturn = new Coffee(merkki);
            return toReturn;
        }*/
    }
}
