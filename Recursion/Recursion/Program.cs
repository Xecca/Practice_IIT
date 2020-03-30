using System;

namespace Recursion
{
    class MainClass
    {
        public static void WriteReversed(char[] items, int startIndex = 0)
        {
            // Выводим в обратном порядке все элементы с индексом больше startIndex
            if (startIndex < items.Length - 1)
                WriteReversed(items, startIndex + 1);
            // а потом выводим сам элемент startIndex
            if (startIndex < items.Length)
                Console.Write(items[startIndex]);
        }

        public static void Main(string[] args)
        {
            WriteReversed(new char[] { '1', '2', '3' });
        }
    }
}
