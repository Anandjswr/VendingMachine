using System;

namespace VendingMachine
{
    public static class Program
    {
        static double balance;
        static string display;
        public struct Coins
        {
            public const double Nickel = 0.05;
            public const double Dime = 0.10;
            public const double Quarter = 0.2;
        }
        public struct Products
        {
            public const double Cola = 1.00;
            public const double Chips = 0.50;
            public const double Candy = 0.65;
        }
        public static void InsertCoin(double coin)
        {
            balance += coin;
            display = "Current Balance: $" + balance;
            Console.WriteLine(display);
        }
        public static void PressButton(double product)
        {
            if (balance >= product)
            {
                balance -= product;
                display = "THANK YOU";
            }
            else
            {
                display = "PRICE: $" + product;
            }
            Console.WriteLine(display);
        }
        public static string CheckDisplay()
        {
            if (balance == 0)
            {
                display = "INSERT COIN";
            }
            return display;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("There are three products: cola for $1.00, chips for $0.50, and candy for $0.65.");
            Console.WriteLine("The vending machine will accept valid coins (nickels(1/20 $), dimes (1/10 $), and quarters(1 / 4 $))");
            Console.WriteLine("Please enter valid coins (nickels(1/20 $), dimes (1/10 $), and quarters(1 / 4 $))");
            double currentCoin = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter products: cola for $1.00, chips for $0.50, and candy for $0.65.");
            double currentProduct = Convert.ToDouble(Console.ReadLine());
            InsertCoin(currentCoin);
            PressButton(currentProduct);
            CheckDisplay();
        }


    }
}
