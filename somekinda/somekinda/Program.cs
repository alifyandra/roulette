using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace somekinda
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;                
                Random ran = new Random();
                var r = new Random();
                string[] color = { "red", "black" };
                string ranColor = color[r.Next(color.Length)]; 
                string guess;
                int bet;
                int money = 500;
                while (money != 0)
                {
                    Console.WriteLine("Roulette Roller by Alifyandra\n");
                    Console.WriteLine("Money:$" + money);
                    Console.WriteLine("Type in any off the following letters below:");
                    Console.WriteLine("a.Even    b.Odd    c.1 to 18  d.19 to 36");
                    guess = (Console.ReadLine());
                    guess.ToLower();
                    bool check = guess == "a" || guess == "b" || guess == "c" || guess == "d";
                    if (check == false)
                    {
                        Console.WriteLine("You did not enter the correct input value(even/odd)");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    else { 
                    int roll = ran.Next(0, 37);
                    bool even = roll % 2 == 0;
                        if (((guess == "a") && (even == true)) || ((guess == "b") && (even == false)))
                        {
                            Console.WriteLine("The roulette rolled: " + ranColor + " " + roll);
                            Console.WriteLine("You won! +$100!");
                            Console.WriteLine("<Press enter to continue>");
                            money += 100;
                            Console.ReadKey();
                        }
                        else if ((guess == "c") && ((roll > 0) && (roll < 19)))
                        {
                            Console.WriteLine("The roulette rolled: " + ranColor + " " + roll);
                            Console.WriteLine("You won! +$100!");
                            Console.WriteLine("<Press enter to continue>");
                            money += 100;
                            Console.ReadKey();
                        }
                        else if ((guess == "d") && ((roll > 18) && (roll < 37)))
                        {
                            Console.WriteLine("The roulette rolled: " + ranColor + " " + roll);
                            Console.WriteLine("You won! +$100!");
                            Console.WriteLine("<Press enter to continue>");
                            money += 100;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("The roulette rolled: " + ranColor + " " + roll);
                            Console.WriteLine("You lost! -$100!");
                            Console.WriteLine("<Press enter to continue>");
                            money -= 100;
                            Console.ReadKey();
                            if (money == 0)
                            {
                                Console.WriteLine("You are out of money.");
                                Console.WriteLine("<Press enter to continue>");
                                Console.ReadKey();
                            }
                        }
                    }
                    Console.Clear();
                }
            }
        }
    }
}
