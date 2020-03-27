using System;
using System.Collections.Generic;
using System.Text;

namespace ListAndLoopsExample
{
    class Company
    {
        /*COMPANY-luokka (nimi, yhteyshenkilö (luokkaa person), maa
        PERSON-luokka (etunimi, sukunimi, puhelinnumero, email)
        DATAHANDLER-luokka (list<coffee>, list<person>
         --> METODI, joka kysyy merkin, hinnan ja paahtoasteen,
        luo näistä instanssin Coffee -> lisää ko. instanssin listaan*/

        public string name;
        public Person contactPerson;
        public string country;

        public Company()
        {

        }

        public Company(string name, Person contactPerson, string country)
        {
            this.name = name;
            this.contactPerson = contactPerson;
            this.country = country;
        }
    }
}
