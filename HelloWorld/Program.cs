using System;

namespace HelloWorld
{
    
    class MainClass
    {
        /// <summary>
        /// Expr1. Как поменять местами значения двух переменных?
        /// </summary>
        /// <returns>vers 1. with third variable, not returns. Swap arguments
        /// inside method</returns>
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
        /// Expr2. Задается натуральное трехзначное число (гарантируется, что
        /// трехзначное).
        /// Развернуть его, т.е. получить трехзначное число, записанное теми же
        /// цифрами в обратном порядке.
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
        /// <summary>
        /// Expr3. Задано время Н часов (ровно). Вычислить угол в градусах
        /// между часовой и минутной стрелками. 
        /// </summary>
        /// <returns>interger with value angle</returns>
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
        /// <summary>
        /// Expr4. Функция возвращает количество чисел, которые имеют простые
        ///     делители, до числа number.
        /// </summary>
        /// <param name="number">число N</param>
        /// <param name="divider1">простой делитель X</param>
        /// <param name="divider2">простой делитель Y</param>
        /// <returns>Количество чисел, меньших N, которые имеют простые делители
        /// X и Y</returns>
        static int DivideCount(int number, int divider1, int divider2)
        {
            int count = 0;
            int temp_num = 0;

            while (temp_num < number)
            {
                if ((temp_num % divider1) == 0 && (temp_num % divider2) == 0)
                    count++;
                temp_num++;
            }
            return count;
        }

        /// <summary>
        /// Expr5. Функция находит количество високосных лет (bissextile years) на отрезке [a, b],
        /// беp использования циклов.
        /// </summary>
        /// <param name="a">начало отсчета</param>
        /// <param name="b">граница подсчета (в годах)</param>
        /// <returns>количество високосных лет (integer)</returns>
        static int BissextileYear(int a, int b)
        {
            int bissextile_count = 0;
            int diff = 0;
            diff = b - a;
            bissextile_count = diff / 4;
            if (a % 4 == 0 || b % 4 == 0 && a != b)
                bissextile_count++;

            return bissextile_count;
        }


        static double Distance(int[] m, int[] p1, int[] p2)
        {
            double dist = 0;
            dist = Math.Abs((((p2[1] - p1[1]) * m[0]) - ((p2[0] - p1[0]) *
                m[1]) + p2[0] * p1[1] - p2[1]*p1[0])) /
                Math.Sqrt(Math.Pow((p2[1] - p1[1]), 2) +
                Math.Pow((p2[0] - p1[0]), 2));

            return dist;
        }

        public static void Main(string[] args)
        {
            //int hours = 16;
            //int num1 = 478;
            int[] m = { 2, 3 };
            int[] p1 = { 10, 12 };
            int[] p2 = { 34, 25 };
            Console.WriteLine("Hello World!");
            //SwapInt1(ref int1, ref int2);
            //SwapInt2(ref int1, ref int2);
            //Console.WriteLine(ReverseInt(num1));
            //Console.WriteLine(AngleDegree(hours));
            //Console.WriteLine(DivideCount(12, 2, 3));
            //Console.WriteLine(BissextileYear(1840, 1852));
            Console.WriteLine(Distance(m, p1, p2));
        }
    }
}
