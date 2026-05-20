using Microsoft.Win32;
using System.Collections.Generic;

// Uppgift 1: Klasserna bör vara personal . Detta räcker då det bara är namn och lön
// Uppgift 2: Namn och lön 

namespace Personalregister
{
    public class Personal
    {

        public string Namn;
        public int Lon;

        public Personal(string namn, int lon)
        {
            Namn = namn;
            Lon = lon;
        }
        // Lösningen nedan hittade jag efter googling, Jag förstår inte varför det blir konstigt resultat utan den??
        // --- Personal lista ---
        // Personalregister.Personal
        public override string ToString()
        {
            return $"Namn: {Namn}, Lön: {Lon}";
        }

    }
    internal class Program
    {
        // Skapa Lista med personalen för att enkelt kunna använda add m.m.
        // Måste ligga utanför Main , antagligen pga att den ska vara tillgänglig 
        static List<Personal> register = new List<Personal>();


        static void Main(string[] args)
        {
            bool menyRun = true;

            while (menyRun == true)
            {
                // MENY
                Console.WriteLine("--- Personalregister ---");
                Console.WriteLine("1. Lägg till personal");
                Console.WriteLine("2. Visa alla personer");
                Console.WriteLine("5. Avsluta");
                Console.Write("Välj: ");

                string val = Console.ReadLine();

                switch (val)
                {
                    case "1":
                        LaggTillPerson();
                        break;

                    case "2":
                        VisaPersoner();
                        break;

                    case "5":
                        menyRun = false;
                        break;

                    default:
                        Console.WriteLine("Välj 1,2 eller 5.");
                        break;
                }
            }
            static void LaggTillPerson()
            {
                Console.Write("Ange namn: ");
                string namn = Console.ReadLine();

                Console.Write("Ange lön: ");
                int lon = int.Parse(Console.ReadLine()); //Gör om inmatningens string till Int.

                register.Add(new Personal(namn, lon));

                Console.WriteLine("Person tillagd.");


            }

            static void VisaPersoner()
            {
                Console.WriteLine("\n--- Personal lista ---");

                if (register.Count == 0) //Kolla om registret är tomt
                {
                    Console.WriteLine("Inga personer registrerade.");
                    return;
                }
                //Lista alla poster
                foreach (Personal person in register)
                {
                    Console.WriteLine(person.ToString()); //Skriv ut med den "nya" ToString

                }
            }
        }
    }

    
}
