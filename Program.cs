using System;
using Microsoft.Data.SqlClient;
namespace CarForHireConsoleApp
    
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "";
            bool isExit = true;
            MainLoop(ref isExit);
            Console.WriteLine("Hi");
            Console.WriteLine("New line");
            
        }

        private static void MainLoop(ref bool isExit)
        {
            MenuBoard();
            while (isExit)
            {
              GetUserChoice(ref isExit);
            }
        }


        private static void MenuBoard()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("1.) Add New Record  *");
            Console.WriteLine("2.) Delete Record   *");
            Console.WriteLine("3.) Edit Record     *");
            Console.WriteLine("4.) Display Records *");
            Console.WriteLine("5.) Exit Program    *");
            Console.WriteLine("*********************");
        }

        private static int GetUserChoice(ref bool isExit)
        {
            Console.WriteLine("Enter choice: ");
            int choice = ValidateInput();
            ProcessMenuSelection(ref choice,ref isExit);
            return choice;

        }

        private static int ProcessMenuSelection(ref int  choice,ref bool isExit)
        {
            switch (choice)
            {
                case 1: InsertRecord();
                    break;

                case 2: DeleteRecord();
                    break;

                case 3: UpdateRecord();
                    break;

                case 4: SearchRecord();
                    break;

                case 5: Console.WriteLine("Exiting.........");
                    isExit = false;
                    break;

                default:Console.WriteLine("INVALID INPUT! PLEASE TRY AGAIN! Options (1-5)");
                    break;
            }
            return choice;
        }

        private static void InsertRecord()
        {
            Console.WriteLine("Insert method");
        }

        private static void DeleteRecord()
        {
            Console.WriteLine("Delete method");
        }

        private static void UpdateRecord() 
        {
            Console.WriteLine("Update record");
        }

        private static void SearchRecord()
        {
            Console.WriteLine("Search record");
        }

        private static int ValidateInput()
        {
            while (true)
            {
                string? input = Console.ReadLine();
                if(int.TryParse(input,out int result))
                {
                    return result;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("INVALID INPUT! NUMBERS ONLY! TRY AGAIN!");
                    Console.ResetColor();
                }
            }
        }
    }
}
