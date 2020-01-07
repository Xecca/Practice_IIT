using System;

namespace HelloWorld
{
    
    class MainClass
    {
        /// <summary>
        /// Expr1. Как поменять местами значения двух переменных?
        /// </summary>
        /// <returns>vers 1. with third variable, not returns. Swap arguments inside method</returns>
        static void SwapInt1(ref int num1, ref int num2)
        {
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
        }
        // vers 2. without additional valiable. Using ref (analog pointers in C)
        static void SwapInt2(ref int num1, ref int num2)
        {
            num1 += num2;
            num2 = num1 - num2;
            num1 -= num2;
        }
        /// <summary>
        /// Expr2. Задается натуральное трехзначное число (гарантируется, что трехзначное).
        /// Развернуть его, т.е. получить трехзначное число, записанное теми же цифрами в обратном порядке.
        /// </summary>
        /// <returns>return reverse integer</returns>
        static int ReverseInt(int number)
        {
            int revnum = 0;
            if (number >= 100 && number <= 999)
            {
                    revnum = (number % 10) * 100;
                    number = number / 10;
                    revnum = revnum + ((number % 10) * 10);
                    revnum = revnum + (number / 10);
            }
            else
                return 0;
            return revnum;
        }

        static int AngleDegree(int hours)
        {
            int angle = 0;
            if (hours > 12)
                hours -= 12;
            if (hours < 6)
                angle = 30 * hours;
            else if (hours > 6)
                angle = 30 * (12 - hours);
            else
                angle = 30 * 6;
            return angle;
        }


        public static void Main(string[] args)
        {
            int hours = 16;
            //int num1 = 478;
            Console.WriteLine("Hello World!");
            //SwapInt1(ref int1, ref int2);
            //SwapInt2(ref int1, ref int2);
            //Console.WriteLine(ReverseInt(num1));
            Console.WriteLine(AngleDegree(hours));
           
        }
    }
}
