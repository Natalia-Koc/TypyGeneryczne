using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatesForTypesAndMethods_5_
{
    class Person
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }

        public Person()
        {
        }

        public Person(string imie, string nazwisko, int wiek)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
        }

        public override string ToString()
        {
            return $"{Imie} {Nazwisko}, {Wiek}";
        }
    }
}
