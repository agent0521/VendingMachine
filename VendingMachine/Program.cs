using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            const int cokePrice = 3;
            const int gatoradePrice = 4;
            const int redBullPrice = 6;
            const int gingerAlePrice = 5;
            const double tax = 1.05;

            String codeEntry;
            const String coke = "A";
            const String gatorade = "B";
            const String redBull = "C";
            const String gingerAle = "D";
            int money;
            double total;
            double change;

            Console.WriteLine("***********************");
            Console.WriteLine("Floyd's Vending Machine");
            Console.WriteLine("***********************");

            Console.WriteLine("Code | Item     | Amount\n   A - Coke       $3.00\n   B - Gatorade   $4.00\n   C - Red Bull   $6.00\n   D - Ginger Ale $5.00");
            Console.WriteLine("***********************\n");

            Console.WriteLine("Enter Code: ");
            codeEntry = Console.ReadLine();

            while (codeEntry != coke &&
                    codeEntry != gatorade &&
                    codeEntry != redBull &&
                    codeEntry != gingerAle)
            {
                Console.WriteLine("Invalid entry!");
                Console.WriteLine("Enter Code: ");
                codeEntry = Console.ReadLine();
            }

            Console.Write("Enter money: $");
            try
            {
                money = Convert.ToInt32(Console.ReadLine());
                switch (codeEntry)
                {
                    case coke:
                        while (money <= cokePrice)
                        {
                            Console.WriteLine("Money is not enough");

                            Console.Write("Enter money: $");
                            money = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("\n\n***********************");
                        Console.WriteLine("**** Order Summary ****");
                        Console.WriteLine("* Coke: $3.00  ");
                        Console.WriteLine("* Money: $" + money);
                        Console.WriteLine("* TAX: 5%");
                        total = cokePrice * tax;
                        change = money - total;
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("* Subtotal: $" + total);
                        Console.WriteLine("* Change: $" + change);
                        Console.WriteLine("***********************");
                        Console.WriteLine("     Thank you! \n  Enjoy your drinks!");
                        Console.WriteLine("***********************\n");
                        break;

                    case gatorade:
                        while (money <= cokePrice)
                        {
                            Console.WriteLine("Money is not enough");

                            Console.Write("Enter money: $");
                            money = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("\n\n***********************");
                        Console.WriteLine("**** Order Summary ****");
                        Console.WriteLine("* Gatorade: $4.00");
                        Console.WriteLine("* Money: $" + money);
                        Console.WriteLine("* TAX: 5%");
                        total = gatoradePrice * tax;
                        change = money - total;
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("* Subtotal: $" + total);
                        Console.WriteLine("* Change: $" + change);
                        Console.WriteLine("***********************");
                        Console.WriteLine("     Thank you! \n  Enjoy your drinks!");
                        Console.WriteLine("***********************\n");
                        break;
                    case redBull:
                        while (money <= cokePrice)
                        {
                            Console.WriteLine("Money is not enough");

                            Console.Write("Enter money: $");
                            money = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("\n\n***********************");
                        Console.WriteLine("**** Order Summary ****");
                        Console.WriteLine("* Red Bull: $6.00");
                        Console.WriteLine("* Money: $" + money);
                        Console.WriteLine("* TAX: 5%");
                        total = redBullPrice * tax;
                        change = money - total;
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("* Subtotal: $" + total);
                        Console.WriteLine("* Change: $" + change);
                        Console.WriteLine("***********************");
                        Console.WriteLine("     Thank you! \n  Enjoy your drinks!");
                        Console.WriteLine("***********************\n");
                        break;
                    case gingerAle:
                        while (money <= cokePrice)
                        {
                            Console.WriteLine("Money is not enough");

                            Console.Write("Enter money: $");
                            money = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("\n\n***********************");
                        Console.WriteLine("**** Order Summary ****");
                        Console.WriteLine("* Ginger Ale: $5.00");
                        Console.WriteLine("* Money: $" + money);
                        Console.WriteLine("* TAX: 5%");
                        total = gingerAlePrice * tax;
                        change = money - total;
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("* Subtotal: $" + total);
                        Console.WriteLine("* Change: $" + change);
                        Console.WriteLine("***********************");
                        Console.WriteLine("     Thank you! \n  Enjoy your drinks!");
                        Console.WriteLine("***********************\n");
                        break;

                    default:
                        Console.WriteLine("Error occured. \nProgram restarting!!!");
                        break;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("An unexpected error occured! \nPlease try again.");
            }
            
            Console.ReadLine();
        }
        
    }
}
