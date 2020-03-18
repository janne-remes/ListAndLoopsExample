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

        public string companysName;
        public Person contactPerson;
        public string country;
    }
}
