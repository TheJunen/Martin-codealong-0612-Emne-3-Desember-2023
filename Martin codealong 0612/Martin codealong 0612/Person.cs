using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    internal class Person
    {
        private string Name { get; set; }
        private string Addresse { get; set; }
        private int Alder { get; set; }

        public Person(string name, string addresse, int alder)
        {
            Name = name;
            Addresse = addresse;
            Alder = alder;
        }

        public void Show()
        {
            Console.WriteLine($"navn : {Navn}, alder: {Alder} og adresse {Adresse}");
        }
    }
}
