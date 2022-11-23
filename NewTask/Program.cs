using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTask
{
    internal abstract class Animal
    {

        public   abstract  void Voice();
        enum requiredBiom
        {
            Tropics,Tundra,Desert
        }
        enum Eating
        {
            Fish,Meat,Hay
        }

        static void Main(string[] args)
        {
            List <Bird>animals=new List<Bird> ();
            while (true)
            {
                Console.WriteLine("bir reqem secin ");
                // Fil,Pinqvin,Peleng
                bool parsed = int.TryParse(Console.ReadLine(), out int choice);
                switch (choice)
                {
                    case 1:
                        int choiceOfElephant=int.Parse(Console.ReadLine());
                        switch(choiceOfElephant)
                        {
                            case 1:
                                Console.WriteLine("we have elephant");
                                break;
                            case 2: Console.WriteLine("Aufff");
                                break;
                            case 3: Console.WriteLine("Elephant is playing");
                                break;
                        }
                       
                        
                        break;
                    case 2:
                        int choiceOfPenguin = int.Parse(Console.ReadLine());
                        switch (choiceOfPenguin)
                        {
                            case 1:
                                Console.WriteLine("we have penguin");
                                break;
                            case 2:
                                Console.WriteLine("Oinkk");
                                break;
                            case 3:
                                Console.WriteLine("Penguin is playing");
                                break;
                        }
                        break;
                    case 3:
                        int choiceOfTiger=int.Parse(Console.ReadLine());
                        switch (choiceOfTiger) {
                            case 1:
                                Console.WriteLine("we have elephant");
                                break;
                            case 2:
                                Console.WriteLine("Aufff");
                                break;
                            case 3:
                                Console.WriteLine("I am playing");
                                break;
                        }
                        break;

                }
            }
            
        }
    }
}
