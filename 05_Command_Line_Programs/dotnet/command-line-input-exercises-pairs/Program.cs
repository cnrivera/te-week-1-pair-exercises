using System;

namespace command_line_input_exercises_pairs
{
    class Program
    {
        /*
        Write a command line program which prompts the user for the total bill, and the amount tendered. It should then display the change required.

        C:\Users> MakeChange

        Please enter the amount of the bill: 23.65
        Please enter the amount tendered: 100.00
        The change required is 76.35
        */
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter the amount of the bill: ");
            string strAmountBill = Console.ReadLine();
            double amtBill = double.Parse(strAmountBill);

            while (amtBill <= 0)
            {
                Console.WriteLine("Please enter valid amount");
                strAmountBill = Console.ReadLine();
                amtBill = double.Parse(strAmountBill);
            }

            Console.WriteLine("Please enter the amount tendered: ");
            string strAmountTendered = Console.ReadLine();
            double amtTendered = double.Parse(strAmountTendered);

            while (amtTendered <= 0)
            {
                Console.WriteLine("You cannot pay 0 dollars");
                strAmountTendered = Console.ReadLine();
                amtTendered = double.Parse(strAmountTendered);
            }

            double changeAmount = amtTendered - amtBill;
            if(changeAmount < 1)
            {
                Console.WriteLine("No change");
            }

           else Console.WriteLine("The change required is $" + changeAmount);






        }
    }
}
