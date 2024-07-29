using System;

namespace Assignment3.Tasks
{
    public static class CheckCourseEligibility
    {
        public static void Execute()
        {
            Console.WriteLine("Task 2: Checking Course Eligibility");
            Console.WriteLine("Enter marks obtained in Physics:");
            int physics = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks obtained in Chemistry:");
            int chemistry = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks obtained in Mathematics:");
            int maths = Convert.ToInt32(Console.ReadLine());

            int total = physics + chemistry + maths;

            if (physics >= 55 && chemistry >= 50 && maths >= 65 && total >= 180)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else if (physics >= 55 && maths >= 65 && total >= 140)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
            Console.WriteLine(); // Blank line for separation
        }
    }
}
