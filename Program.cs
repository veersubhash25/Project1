
using System;

namespace _44663
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
            char yourchoice= ' ';

            bool isImmigrant;
            double fineAmount;
while (yourchoice != 'n'){
            Console.WriteLine("Enter the ticket for the crime \n  1.Drunk and Drive \n 2. Shop Lifing \n 3.OverSpeeding \n");
            int choice = Convert.ToInt16(Console.ReadLine());
            
            
            

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Your crime is Drunk and Drive\n");
                        isImmigrant = true;
                        Console.WriteLine($" Is Your visa  revoked {isImmigrant} ");

                        fineAmount = TotalFineAmount("Drunk and Drive");
                        Console.WriteLine($"Your fine amount is :{fineAmount}");
                        break;
                    case 2 :
                        Console.WriteLine("Your crime is Shop Lifting");
                        Console.WriteLine("Enter your shop lifting amount");
                        int shopLiftingAmount = Convert.ToInt16(Console.ReadLine());

                        if (shopLiftingAmount < 1000)
                        {
                            isImmigrant = false;
                            Console.WriteLine($" Is Your visa  revoked {isImmigrant} ");
                            Console.WriteLine("Your crime is based on cultural differences");
                            
                            fineAmount = TotalFineAmount("Shop Lifting");
                            Console.WriteLine($"Your fine amount is :{fineAmount}");

                        }
                        if (shopLiftingAmount > 1000)
                        {
                            isImmigrant = true;
                            Console.WriteLine($" Is Your visa  revoked {isImmigrant} ");
                            Console.WriteLine("Your crime is based on  felony");

                            fineAmount = TotalFineAmount("Shop Lifting");
                            Console.WriteLine($"Your fine amount is :{fineAmount}");
                            
                        }
                        break; 
                    case 3:
                        Console.WriteLine("Your crime is OverSpeeding");

                        fineAmount = TotalFineAmount("OverSpeeding");
                        Console.WriteLine($"Your fine amount is :{fineAmount}");
                        break;
                    default:
                        Console.WriteLine("Enter a valid input ");

                        break;
                }
                Console.WriteLine("Enter if you have commited other  crime");
                yourchoice = Convert.ToChar(Console.ReadLine());


            }
        }

        public static double TotalFineAmount(String crime)
        {
            decimal tax = 1.18m;
            int overSpeedingvalue = 0;
            if (crime == "Drunk and Drive")
            {
                return 700 * Convert.ToDouble(tax);
            }
            if (crime == "Shop Lifting")
            {
                return 400 * Convert.ToDouble(tax);
            }
            if (crime == "OverSpeeding")
            {
                Console.WriteLine("Enter the speeding value");
                overSpeedingvalue = Convert.ToInt16(Console.ReadLine());
                if (overSpeedingvalue < 10)
                {
                    return 100 * Convert.ToDouble(tax);
                }
                if (overSpeedingvalue > 10)
                {
                    return 200 * Convert.ToDouble(tax);
                }

            }

            return 0;
        }
    }
}

