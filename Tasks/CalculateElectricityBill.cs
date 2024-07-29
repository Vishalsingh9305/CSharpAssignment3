using System;

namespace Assignment3.Tasks
{
    public static class CalculateElectricityBill
    {
        public static void Execute()
        {
            Console.WriteLine("Task 3: Calculating Electricity Bill");
            Console.WriteLine("Enter Customer ID:");
            int customerId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Customer Name:");
            string customerName = Console.ReadLine();

            Console.WriteLine("Enter Units Consumed:");
            int unitsConsumed = Convert.ToInt32(Console.ReadLine());

            double chargePerUnit = 0;

            if (unitsConsumed <= 199)
            {
                chargePerUnit = 1.20;
            }
            else if (unitsConsumed >= 200 && unitsConsumed < 400)
            {
                chargePerUnit = 1.50;
            }
            else if (unitsConsumed >= 400 && unitsConsumed < 600)
            {
                chargePerUnit = 1.80;
            }
            else if (unitsConsumed >= 600)
            {
                chargePerUnit = 2.00;
            }

            double totalAmount = unitsConsumed * chargePerUnit;
            double surcharge = 0;

            if (totalAmount > 400)
            {
                surcharge = totalAmount * 0.15;
            }

            double netAmount = totalAmount + surcharge;

            // Ensuring minimum bill of Rs. 100
            if (netAmount < 100)
            {
                netAmount = 100;
            }

            Console.WriteLine($"Customer IDNO: {customerId}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"unit Consumed: {unitsConsumed}");
            Console.WriteLine($"Amount Charges @Rs. {chargePerUnit} per unit: {totalAmount:F2}");
            Console.WriteLine($"Surchage Amount: {surcharge:F2}");
            Console.WriteLine($"Net Amount Paid By the Customer: {netAmount:F2}");
            Console.WriteLine(); // Blank line for separation
        }
    }
}
