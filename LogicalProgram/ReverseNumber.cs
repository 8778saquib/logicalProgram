﻿using System;
namespace LogicalProgram
{
    public class ReverseNumber
    {
        public void Reverse()
        {
            int reverse = 0, rem;
            Console.WriteLine("Enter a number for reversing: ");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number != 0)
            {
                rem = number % 10;
                reverse = reverse * 10 + rem;
                number = number / 10;
            }
            Console.WriteLine("Reversed number is: {0}", reverse);
        }
    }
}
