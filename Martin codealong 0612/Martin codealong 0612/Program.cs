using app;
using System.Runtime.InteropServices;

namespace app //Martin_codealong_0612
{ 
    class Program
    {
        static void Main(string[] args)
        {
            var fend = new Program2();
            fend.Lars();
            fend.Marte();
            fend.Torje();
            fend.Tine();
            fend.Josef();

            var people = new List<Person> {
                new("Terje", "Karl Johan", 40),
                new("Marie", "Larviksgaten", 32)
            };

            var personasd = new Person("Geir", "asdasd", 55);
            people.Add(personasd);

            foreach(var person3 in people)
            {
                person3.Show();
            }

            var person = new Person("Terje", "Karl Johan", 40);
            person.Show();
            var person2 = new Person("Terje", "Karl Johan", 40);
            person2.Show();


        }
    }
}

//var fend = new Program2();
//fend.Lars();
//fend.Marte();
//fend.Torje();
//fend.Tine();
//fend.Josef();

//var people = new List<Person> {
//                new("Terje", "Karl Johan", 40),
//                new("Marie", "Larviksgaten", 32)
//            };

//foreach (var person3 in people)
//{
//    person3.Show();
//}

//var person = new Person("Terje", "Karl Johan", 40);
//person.Show();
//var person2 = new Person("Terje", "Karl Johan", 40);
//person2.Show();

