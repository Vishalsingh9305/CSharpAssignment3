using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Count Duplicate Elements");
                Console.WriteLine("2. Check Course Eligibility");
                Console.WriteLine("3. Calculate Electricity Bill");
                Console.WriteLine("0. Exit");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Exiting program...");
                        return;
                    case 1:
                        Tasks.CountDuplicateElements.Execute();
                        break;
                    case 2:
                        Tasks.CheckCourseEligibility.Execute();
                        break;
                    case 3:
                        Tasks.CalculateElectricityBill.Execute();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 0 to 3.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear(); // Clears console for next iteration
            }
        }
    }
}
