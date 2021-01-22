using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2019Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize variables

            /* Add program flow of control
             * for this application that is likely a while loop
             * that makes a call to a method to display the menu and return the users choice
             * The flow of control loop would use the result from the menu choice
             * to call the proper method or exit the program.
             * 
             * That means at a minimun you will have a method for the menu
             * a method for the triangle and a method for the numbers table
             */

            int choice = 0;

            while(choice !=3)
            {
                choice = Menu();
                switch (choice)
                {
                    case 1: Triangle(); break;

                    case 2: Numbers(); break;

                    case 3: return;
                }
            }


        }

        static int Menu()
        {
            int choice = 0;

            while(choice < 1 || choice > 3)
            {
                Console.WriteLine("MENU\n\t(1) Triangle\n\t(2) Numbers\n\t(3) Exit\nPlease enter menu choice: ");
                choice = int.Parse(Console.ReadLine());

                if (choice < 1 || choice > 3)
                    Console.WriteLine("\nError: Invalid menu choice.\n");
            }

            return choice;
        }

        static void Triangle()
        {
            Console.WriteLine();

            for(int r = 10; r > 0; r--)
            {
                for (int c = r; c > 0; c--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.WriteLine();
        }

        static void Numbers()
        {
            Console.WriteLine();

            for (int c = 1; c <= 4; c++)
            {
                for (int r = 0; r < 11; r++)
                {
                    if(r == 0)
                    {
                        Console.Write(c);
                    }
                    else
                    {
                        Console.Write("\t" + (c * (r-1)));
                    }
                }

                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}
