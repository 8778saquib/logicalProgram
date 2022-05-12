using System;

namespace LogicalProgram
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter the choice");
            Console.WriteLine(" 1.FibonacciSeries ");
            Console.WriteLine(" 2.PerfectNumber ");
            Console.WriteLine(" 3.PrimeNumber ");
            Console.WriteLine(" 4.ReverseNumber");
            Console.WriteLine(" 5. CouponNumbers");
            Console.WriteLine(" 6.SimulateStopwatch");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    FibonacciSeries a = new FibonacciSeries();
                    a.Fibonacci();

                    break;
                case 2:
                    PerfectNumber b = new PerfectNumber();
                    b.perfect();
                    break;
                case 3:
                    PrimeNumber c = new PrimeNumber();
                    c.CheckPrime();
                    break;
                case 4:
                    ReverseNumber d = new ReverseNumber();
                    d.Reverse();

                    break;
                case 5:
                    CouponNumbers e = new CouponNumbers();
                    e.Coupon();

                    break;
                case 6:
                    SimulateStopwatch f = new SimulateStopwatch();
                    f.Stopwatch();
                    break;
                default:
                    Console.WriteLine("Please enter the correct choice");
                    break;
            }











        }
    }
}
