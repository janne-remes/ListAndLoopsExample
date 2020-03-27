using System;
using System.Collections.Generic;
using System.Text;

namespace ListAndLoopsExample
{
    class MainMenu
    {
        public DataHandler dataHandler;

        public MainMenu(DataHandler dataHandler)
        {
            this.dataHandler = dataHandler;
        }

        public void InitializeMainMenu()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = ShowMainMenu();
            }
        }

        private bool ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("MAIN MENU");
            Console.WriteLine("1. Lisää henkilö");
            Console.WriteLine("2. Henkilölista");
            Console.WriteLine("3. Lisää yritys");
            Console.WriteLine("4. Yrityslista");
            Console.WriteLine("5. Lisää kahvi");
            Console.WriteLine("6. Kahvilista");
            Console.WriteLine("0. EXIT");

            int selected = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (selected)
            {
                case 1:
                    dataHandler.AddPersonToList();
                    break;
                case 2:
                    //dataHandler.PrintPersonList();
                    dataHandler.SelectPersonFromList();
                    //Console.WriteLine($"Valittu: {person.firstName} {person.lastName} | {person.phone} | {person.email}");
                    break;
                case 3:
                    dataHandler.AddNewCompanyToList();
                    break;
                case 4:
                    dataHandler.PrintCompanyList();
                    break;
                case 5:
                    dataHandler.AddNewCoffeeToList();
                    break;
                case 6:
                    dataHandler.PrintCoffeeList();
                    break;
                case 0:
                    return false;
                default:
                    Console.Clear();
                    return true;
            }
            Console.ReadKey();
            return true;
        }
    }
}
