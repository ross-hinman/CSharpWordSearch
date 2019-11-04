using System;

namespace WordSearch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string letters = "Y\tT\tE\tT\tI\tH\tH\tL\tT\tP\nW\tM\tR\tE\tR\tW\tX\tW\tE\tC\nM\tM\tY\tA\tK\tB\tX\tW\tN\tD\nP\tE\tT\tB\tC\tC\tJ\tY\tR\tZ\nV\tW\tQ\tT\tL\tT\tM\tA\tE\tV\nR\tE\tT\tU\tP\tM\tO\tC\tT\tK\nY\tX\tY\tF\tP\tB\tI\tR\tN\tZ\nI\tU\tE\tJ\tY\tU\tR\tZ\tI\tX\nN\tM\tU\tE\tZ\tV\tK\tT\tX\tX\nW\tR\tK\tA\tV\tO\tC\tA\tD\tO\n";
            
            Console.WriteLine("How many words can you find?");
            int found = 0;
            int avocado = 0;
            int keyboard = 0;
            int computer = 0;
            int tractor = 0;
            int internet = 0;
            bool play = true;
            while(play == true)
            {
                
                Console.WriteLine(letters);

                Console.WriteLine("Write a word you think you see in the puzzle:");
                string word = Console.ReadLine().ToLower();
                if(word == "avocado")
                {
                    if(avocado == 1)
                    {
                        Console.WriteLine("You already found that!");
                        continue;
                    }
                    else
                    {
                        avocado++;
                        Console.WriteLine("You found one!");
                        found++;
                        Console.WriteLine($"You have {5 - found} words left to find!");
                        if (found == 5)
                        {
                            Console.WriteLine("You found all the words!");
                            play = false;
                        }
                    }
                    
                }
                else if (word == "keyboard")
                {
                    if (keyboard == 1)
                    {
                        Console.WriteLine("You already found that!");
                        continue;
                    }
                    else
                    {
                        keyboard++;
                        Console.WriteLine("You found one!");
                        found++;
                        Console.WriteLine($"You have {5 - found} words left to find!");
                        if (found == 5)
                        {
                            Console.WriteLine("You found all the words!");
                            play = false;
                        }
                    }

                }
                else if (word == "computer")
                {
                    if (computer == 1)
                    {
                        Console.WriteLine("You already found that!");
                        continue;
                    }
                    else
                    {
                        computer++;
                        Console.WriteLine($"You have {5 - found} words left to find!");
                        if (found == 5)
                        {
                            Console.WriteLine("You found all the words!");
                            play = false;
                        }
                    }

                }
                else if (word == "tractor")
                {
                    if (tractor == 1)
                    {
                        Console.WriteLine("You already found that!");
                        continue;
                    }
                    else
                    {
                        tractor++;
                        Console.WriteLine("You found one!");
                        found++;
                        Console.WriteLine($"You have {5 - found} words left to find!");
                        if (found == 5)
                        {
                            Console.WriteLine("You found all the words!");
                            play = false;
                        }
                    }

                }
                else if (word == "internet")
                {
                    if (internet == 1)
                    {
                        Console.WriteLine("You already found that!");
                        continue;
                    }
                    else
                    {
                        internet++;
                        Console.WriteLine("You found one!");
                        found++;
                        Console.WriteLine($"You have {5 - found} words left to find!");
                        if (found == 5)
                        {
                            Console.WriteLine("You found all the words!");
                            play = false;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("That's not a word in this puzzle. Try again!");
                    continue;
                }
            }

            
            Console.ReadLine();
            
        }
    }
}
