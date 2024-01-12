using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class Program2
    {
        public void Lars()
        {
            string navn = "lars";
            int alder = 23;
            string adresse = "Oslogaten 10";
            if (alder >= 30)
            {
                Console.WriteLine($"navn : {navn}, alder: {alder} og adresse {adresse}");
            }
        }

        public void Marte()
        {
            string navn = "lars";
            int alder = 22;
            string adresse = "Fende 10";
            if (alder >= 30)
            {
                Console.WriteLine($"navn : {navn}, alder: {alder} og adresse {adresse}");
            }
        }

        public void Torje()
        {
            string navn = "Torje";
            int alder = 50;
            string adresse = "Fysjeveien 20";
            if (alder >= 30)
            {
                Console.WriteLine($"navn : {navn}, alder: {alder} og adresse {adresse}");
            }
        }
        public void Tine()
        {
            string navn = "Tine";
            int alder = 35;
            string adresse = "Vergeland 2";
            if (alder >= 30)
            {
                Console.WriteLine($"navn : {navn}, alder: {alder} og adresse {adresse}");
            }
        }
        public void Josef()
        {
            string navn = "Josef";
            int alder = 29;
            string adresse = "Fergegaten 15";
            if (alder >= 30)
            {
                Console.WriteLine($"navn : {navn}, alder: {alder} og adresse {adresse}");
            }
        }
    }
}
