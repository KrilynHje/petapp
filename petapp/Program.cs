using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace petapp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameActive = true;
            int petIndex = 0;
            int choice = 0;

            List<Pet> pets = new List<Pet>
        {
            new Pet ("Fido",0),
            new Pet ( "Whiskers",0),
            new Pet ( "Pikachu",0),
            new Pet ("Nemo" ,0),
        };
            while (gameActive)
            {
                Console.WriteLine("\n Velkommen til PP-Dyrebarnehage! \n Velg kjæledyr ved å skrive kjæledyrets tall og trykke Enter: ");
                for (int i = 0; i < pets.Count; i++)
                {
                    Console.WriteLine($" {i + 1}. {pets[i].Name}");

                }

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Ugyldig input. Prøv igjen.");
                    continue;
                }
                petIndex = choice - 1;
                //Console.WriteLine($"\nDu har valgt {pets[petIndex].Name}.");



                Console.WriteLine($"\n Hva vil du gjøre med {pets[petIndex].Name}");
                Console.WriteLine("1. Kose");
                Console.WriteLine("2. Mate");
                Console.WriteLine("3. Gå hjem for dagen");

                choice = 0;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Ugyldig input. Prøv igjen.");
                    continue;

                }

                switch (choice)
                {
                    case 1:
                        pets[petIndex].PlayWith();
                        break;
                    case 2:
                        pets[petIndex].Feed();
                        break;
                    case 3:
                        gameActive = false;
                        Console.WriteLine("Takk for hjelpen Velkommen igjen! ");
                        break;
                    default:
                        Console.WriteLine("Ugyldig kommando. Prøv igjen.");
                        break;

                }

            }
        }




    }

    class Pet
    {
        public string Name { get; set; }
        public int NumberOfCuddles { get; set; }
        public bool IsHungry { get; set; }

        public Pet(string name, int numberOfCuddles)
        {
            Name = name;
            NumberOfCuddles = numberOfCuddles;
            IsHungry = false;
        }

        public void Feed()
        {
            IsHungry = false;
            Console.WriteLine($"{Name} fikk mat");
        }

        public void PlayWith()
        {
            NumberOfCuddles++;
            Console.WriteLine($"{Name} Har fått: " + NumberOfCuddles + " koser i dag!");
        }







    }
}

