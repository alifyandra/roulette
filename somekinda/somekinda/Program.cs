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
            Console.ForegroundColor = ConsoleColor.Yellow;                
            Random ran = new Random();
            var r = new Random();
            string[] color = { "Red", "Black" };                 
            string guess;
            int attempts = 0;
            int bet;
            int money = 500;
            while (money != 0)
            {
                Console.WriteLine("Roulette Roller by Alifyandra\n");
                Console.WriteLine("Money:$" + money+"                      Attempts: "+attempts);
                Console.WriteLine("Type in any of the following letters below:");
                Console.WriteLine("a.Even    b.Odd    c.1 to 18    d.19 to 36");
                Console.WriteLine("e.Red     f.Black  g.1st 12     h.2nd 12");
                Console.WriteLine("i.3rd 12\n");
                guess = (Console.ReadLine());
                //guess verifier
                guess.ToLower();
                bool check = guess == "a" || guess == "b" || guess == "c" || guess == "d" || guess == "e" || guess == "f" || guess == "g" || guess == "h" || guess == "i";                                                     
                if (check == false)
                {
                    Console.WriteLine("\nYou did not enter the correct input value!(a/b/c/d/e/f/g/h/i)");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else
                {
                bet:
                    Console.WriteLine("\nEnter an amount to bet:");
                    bet=Convert.ToInt32(Console.ReadLine());
                    //bet verifier
                    if (bet > money)
                    {
                        Console.WriteLine("You dont have enough money!");
                        Console.WriteLine("<Press enter to try again>");
                        Console.ReadKey();                          
                        goto bet;
                    }
                    else {
                        money -= bet;
                        int roll = ran.Next(0, 37);
                        string ranColor = color[r.Next(color.Length)];
                        bool even = roll % 2 == 0;
                        if ((((guess == "a") && (even == true))) || (((guess == "b") && (even == false)))||((guess == "e") && (ranColor == "Red")||(guess == "f") && (ranColor == "Black")))
                        {
                            Console.WriteLine("\nThe roulette rolled: " + ranColor + " " + roll);
                            Console.WriteLine("You won! +$" + bet * 2 + "!");
                            Console.WriteLine("<Press enter to continue>");
                            money += bet * 2;
                            attempts += 1;
                            Console.ReadKey();
                        }
                        else if ((guess == "c") && ((roll > 0) && (roll < 19)))
                        {
                            Console.WriteLine("\nThe roulette rolled: " + ranColor + " " + roll);
                            Console.WriteLine("You won! +$" + bet * 2 + "!");
                            Console.WriteLine("<Press enter to continue>");
                            money += bet * 2;
                            attempts += 1;
                            Console.ReadKey();
                        }
                        else if ((guess == "d") && ((roll > 18) && (roll < 37)))
                        {
                            Console.WriteLine("\nThe roulette rolled: " + ranColor + " " + roll);
                            Console.WriteLine("You won! +$" + bet * 2 + "!");
                            Console.WriteLine("<Press enter to continue>");
                            money += bet * 2;
                            attempts += 1;
                            Console.ReadKey();
                        }       
                        else if ((guess == "g") && (roll > 0 && roll < 13) || (guess == "h") && (roll > 12 && roll < 25) || (guess == "i") && (roll > 24 && roll < 37))
                        {
                            Console.WriteLine("\nThe roulette rolled: " + ranColor + " " + roll);
                            Console.WriteLine("You won! +$" + bet * 3 + "!");
                            Console.WriteLine("<Press enter to continue>");
                            money += bet * 3;
                            attempts += 1;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\nThe roulette rolled: " + ranColor + " " + roll);
                            Console.WriteLine("You lost! -$" + bet + "!");
                            Console.WriteLine("<Press enter to continue>");
                            attempts += 1;
                            Console.ReadKey();
                            if (money == 0)
                            {
                                Console.WriteLine("\nYou are out of money.");
                                Console.WriteLine("<Press enter to exit game>");
                                Console.ReadKey();
                            }
                        }
                    }
                }
                Console.Clear();                
            }
        }
    }
}
