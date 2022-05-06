using System;

namespace KrokodilleSpillet
{
    class Program
    {
        static void Main(string[] args)
        {



            bool status = true;
            int win = 0;
            int tap = 0;



            while (status)
            {
                Random rnd = new Random();
                int number1 = rnd.Next(1, 11);
                int number2 = rnd.Next(1, 11);

                Console.WriteLine("The Crocodile game!");
                Console.WriteLine("Krokodille: " + number1 + "_" + number2);
                Console.WriteLine("Velg mellom > | = | <");

                var brukerValg = Console.ReadLine();
                

                Console.WriteLine(number1 + brukerValg + number2);

                Console.WriteLine("Du valgte: " + brukerValg);
                Console.WriteLine("Krokodille: ");
                if (brukerValg != ">" && brukerValg != "=" && brukerValg != "<")
                {
                    Console.WriteLine("Ugyldig tegn");
                    status = false;
                }
                else
                {
                    
                    if (brukerValg == ">" && number1 > number2) win++;
                    if (brukerValg == "=" && number1 > number2) tap++;
                    if (brukerValg == "<" && number1 > number2) tap++;

                    if (brukerValg == "=" && number1 == number2) win++;
                    if (brukerValg == ">" && number1 == number2) tap++;
                    if (brukerValg == "< " && number1 == number2) tap++;

                    if (brukerValg == "<" && number1 < number2) win++;
                    if (brukerValg == ">" && number1 < number2) tap++;
                    if (brukerValg == "=" && number1 < number2) tap++;
                    

                    Console.WriteLine("seier: " + win);
                    Console.WriteLine("tap: " + tap);
                    if (win == 10 || tap == 10)
                    {
                        if (tap == 10) Console.WriteLine("Du tapte!");
                        status = false;
                        if (win == 10) Console.WriteLine("Du vant!");
                    }
                }
            }
        }
    }
}
