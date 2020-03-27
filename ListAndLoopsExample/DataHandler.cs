using System;
using System.Collections.Generic;
using System.Text;

namespace ListAndLoopsExample
{
    class DataHandler
    {
        public List<Person> persons = new List<Person>();
        public List<Coffee> coffees = new List<Coffee>();
        public List<Company> companies = new List<Company>();


        #region Person stuff
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

        public Person AddPersonToList()
        {
            var person = CreatePerson();
            this.persons.Add(person);
            Console.WriteLine("Henkilö lisätty listaan.");

            return person;
        }

        public void PrintPersonList()
        {
            //FillPersonsWithTestData();
            for(int i = 0; i < this.persons.Count; i++)
            {
                Console.WriteLine($"{i+1}. {this.persons[i].firstName} {this.persons[i].lastName}");
            }
        }

        public Person SelectPersonFromList()
        {
            PrintPersonList();
            Console.WriteLine("Valitse henkilön numero listalta");
            var selected = int.Parse(Console.ReadLine());
            Console.WriteLine($"Valittu: {this.persons[selected - 1].firstName} {this.persons[selected - 1].lastName} | {this.persons[selected - 1].phone} | {this.persons[selected - 1].email}");
            return this.persons[selected - 1];
            //Console.ReadKey();
            
        }

        #endregion

        #region Coffee stuff

        public void FillCoffeesWithTestData()
        {
            Person contactPerson1 = new Person("Teppo", "Testaaja", "723 998 8213", "tepontestit@teppo.fi");
            Company testCompany1 = new Company("Testiyritys 1", contactPerson1, "Finland");
        }
        
        public Coffee CreateCoffee()
        {
            Console.WriteLine("Anna kahvin merkki");
            string brand = Console.ReadLine();
            Console.WriteLine("Anna kahvin hinta");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Anna paahtoaste (väliltä 1-5)");
            int asiakkaanPaahto = int.Parse(Console.ReadLine());
            Coffee.Roast roast = (Coffee.Roast)asiakkaanPaahto;

            Company importer = null;
            bool importerSelected = false;
            while (!importerSelected)
            {
                Console.Clear();

                Console.WriteLine("Mikä on maahantuova yritys?");
                Console.WriteLine("\t\t1. Valitse yritys listalta");
                Console.WriteLine("\t\t2. Syötä uusi yritys");

                int selectedCompany = int.Parse(Console.ReadLine());

                switch (selectedCompany)
                {
                    case 1:
                        Console.Clear();
                        importer = SelectCompanyFromList();
                        importerSelected = true;
                        break;
                    
                    case 2:
                        Console.Clear();
                        importer = AddNewCompanyToList();
                        importerSelected = true;
                        break;

                    case 3:
                        importer = null;
                        importerSelected = true;
                        break;
                    
                    default:
                        break;
                }
            }

            Coffee newCoffeeObject = new Coffee(brand, price, roast, importer);
            return newCoffeeObject;
        }

        public void AddNewCoffeeToList()
        {
            Coffee toAdd = CreateCoffee();
            this.coffees.Add(toAdd);
            Console.WriteLine("Kahvi lisättiin listaan.");
        }

        public void PrintCoffeeList()
        {
            if (this.coffees.Count == 0)
            {
                Console.WriteLine("Kahvilista on tyhjä.");
                return;
            }

            int i = 1;

            foreach (Coffee coffee in this.coffees)
            {
                Console.WriteLine($"{i}. Merkki: {coffee.brand}");
                Console.WriteLine($"Paahteisuus: {coffee.roast}");
                Console.WriteLine($"Maahantuoja: {coffee.importer.name}");
                i++;
            }
        }

        public Coffee SelectCoffeeFromList()
        {
            PrintCoffeeList();
            Console.WriteLine("Syötä valittavan yrityksen numero:");
            var selected = int.Parse(Console.ReadLine());
            return this.coffees[selected - 1];
        }

        #endregion

        #region Company stuff

        public Company CreateCompany()
        {
            Console.WriteLine("Anna yrityksen nimi");
            string companysName = Console.ReadLine();
            
            Console.WriteLine("Anna yrityksen maa");
            string companysCountry = Console.ReadLine();

            bool personIsSelected = false;

            Person contactPerson = null;

            while (!personIsSelected)
            {
                Console.Clear();

                Console.WriteLine("1. Valitse yhteyshenkilö listalta.");
                Console.WriteLine("2. Lisää uusi yhteyshenkilö");
                Console.WriteLine("3. Ei yhteyshenkilöä");

                var selection = int.Parse(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        contactPerson = SelectPersonFromList();
                        personIsSelected = true;
                        break;
                    case 2:
                        contactPerson = AddPersonToList();
                        personIsSelected = true;
                        break;
                    case 3:
                        personIsSelected = true;
                        break;
                    default:
                        personIsSelected = false;
                        break;
                }
            }

            Company company = new Company(companysName, contactPerson, companysCountry);

            return company;
        }

        public Company AddNewCompanyToList()
        {
            Company company = CreateCompany();

            this.companies.Add(company);

            Console.WriteLine("Yritys lisättiin listalle.");

            return company;
        }

        public void PrintCompanyList()
        {
            if (this.companies.Count == 0)
            {
                Console.WriteLine("Yrityslista on tyhjä.");
                return;
            }

            int i = 1;

            foreach (Company company in this.companies)
            {
                Console.WriteLine($"{i}. Nimi: {company.name}");
                Console.WriteLine($"Yhteyshenkilö: {company.contactPerson.firstName} {company.contactPerson.lastName}");
                i++;
            }
        }

        public Company SelectCompanyFromList()
        {
            PrintCompanyList();
            Console.WriteLine("Syötä valittavan yrityksen numero");

            int selected = int.Parse(Console.ReadLine());

            return this.companies[selected - 1];

        }

        #endregion
    }
}