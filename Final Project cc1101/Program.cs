using System;

namespace Final_Project_cc1101
{
    class Program
    {
        //Method for displaying the welcome sequence
        static void welcome()
        {
            Console.WriteLine("Welcome to the number game!");
            Console.WriteLine("Please enter a number and this application will determine if the number is odd or even");
        }
        //Method to determine if number is odd or even and display
        static string calc(int x)
        {
            string t;
            x = x % 2;

            if (x == 0 )
            {
                t = "This number is even";
            }
            else if(x > 0)
            {
                t = "This number is odd";
            }
            else
            {
                t = "Please enter a number";
            }
            return t;
        }
        //Method to determine if user/player wants to run the program again
        static bool ending()
        {
            bool cont = true;
            Console.WriteLine("Do you want to play again? y/n");
            string desi = Console.ReadLine();

            desi = desi.ToLower();

            if(desi == "y")
            {
                cont = true;
            }
            else
            {
                cont = false;
            }

            return cont;
        }
        static void Main(string[] args)
        {
            bool conti = true;

            while(conti == true)
            {
                welcome();
                int x = int.Parse(Console.ReadLine());
                string y = calc(x);

                Console.WriteLine(y);

                conti = ending();
                Console.Clear();
            }
        }
    }
}
