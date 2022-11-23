﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    internal class Menu
    {
        public static void MenuOptions()
        {
            do
            {
                Console.WriteLine("");
                Console.WriteLine("             MAIN MENU             ");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("|    [1.]  Accounts                  | ");
                Console.WriteLine("|    [2.]  Transfer                  | ");
                Console.WriteLine("|    [3.]  Withdraw                  | ");
                Console.WriteLine("|    [4.]  Logout                    | ");
                Console.WriteLine("|    [5.]  Exit application          | ");
                Console.WriteLine("--------------------------------------");


                try
                {
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            accounts();
                            break;

                        case 2:
                            transfer();
                            break;

                        case 3:
                            withdraw();
                            break;

                        case 4:
                            LogIn.Accounts();
                            break;

                        default:
                            Environment.Exit(0);
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input!");
                    Console.ReadLine();
                }

                Console.Clear();
            } while (true);
        }

        public static void accounts()
        {

        }

        public static void transfer()
        {

        }

        public static void withdraw()
        {

        }
    }
}
