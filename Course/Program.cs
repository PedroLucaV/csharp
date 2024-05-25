using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 127;
            sbyte y = sbyte.MinValue;
            x++;
            Console.WriteLine(y);
        }
    }
}