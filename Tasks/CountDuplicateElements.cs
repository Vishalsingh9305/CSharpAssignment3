using System;
using System.Linq;

namespace Assignment3.Tasks
{
    public static class CountDuplicateElements
    {
        public static void Execute()
        {
            int[] arr = { 1, 2, 3, 4, 4, 2, 5 };

            var duplicates = arr
                .GroupBy(x => x)
                .Where(g => g.Count() > 1)
                .Select(g => new { Element = g.Key, Count = g.Count() });

            Console.WriteLine("Task 1: Counting Duplicate Elements");
            Console.WriteLine("Duplicate elements and their counts:");
            foreach (var duplicate in duplicates)
            {
                Console.WriteLine($"Element: {duplicate.Element}, Count: {duplicate.Count}");
            }
            Console.WriteLine(); // Blank line for separation
        }
    }
}
