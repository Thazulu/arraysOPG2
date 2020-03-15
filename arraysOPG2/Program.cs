using System;
using System.Linq;
namespace arraysOPG2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fornavne = { "Ib", "Kim", "Helle", "Jens", "Ove" };
            string[] efternavne = { "Jensen", "Nielsen", "Larsen" };
            string[] Klassenavne = { "Kim", "Lasse", "Toke", "Kasper", "Flemming", "Christian", "Mathias", "Steffan", "Benjamin", "Niclas", "Gustav", "Ascha", "Jessie", "Marcus", "Karl-Emil", "Christoffer", "Alexander", };

            

            Console.WriteLine(fornavne[0]);
            //(fornavne[Fornavne.Length -1]); tager det sidste fornavn i arrayet, i tilfælde af at der kommer flere elementer
            Console.WriteLine(fornavne[fornavne.Length -1]);


            // laver 3 linje skift
            for (int AntalLines = 0; AntalLines < 3; AntalLines++)
            {
                Console.WriteLine();
            }

            // udskriver alle fornavne i arrayet
            foreach (var fornavn in fornavne)
            {
                Console.WriteLine(fornavn);
            }

            // laver 3 linje skift
            for (int AntalLines = 0; AntalLines < 3; AntalLines++)
            {
                Console.WriteLine();
            }


            // udskriver alle fornavne og efternavne
            foreach (var fornavn in fornavne)
            {

                foreach (var efternavn in efternavne)
                {
                    Console.WriteLine(fornavn + " " + efternavn);
                }

            }

            Console.WriteLine("");

            // Måden som lars forklarede det på.
            for (int NyNavn = 0; NyNavn < efternavne.Length; NyNavn++)
            {
                Console.WriteLine("indtast nyt efternavne {0}", NyNavn + 1);
                efternavne[NyNavn] = Console.ReadLine();

            }
            Console.WriteLine("");
            foreach (var fornavn in fornavne)
            {

                foreach (var efternavn in efternavne)
                {
                    Console.WriteLine(fornavn + " " + efternavn);
                }

            }

            Random rnd = new Random();

            Console.WriteLine("Skriv antal elever som skal udskrives");
            int Antal = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Antal; i++)
            {
                Console.WriteLine("De tilfældige er : {0}", Klassenavne[rnd.Next(0, Klassenavne.Length)]);
            }


        }
    }
}
