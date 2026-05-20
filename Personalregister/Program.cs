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

        


    }
    internal class Program
    {
        

        static void Main(string[] args)
        {
            bool menyRun = true;

            while (menyRun==true)
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
               
                
            }

            static void VisaPersoner()
            {
               
            }
        }
    }

    
}
