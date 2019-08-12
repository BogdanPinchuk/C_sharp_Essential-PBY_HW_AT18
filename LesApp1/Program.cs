using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibClass = MyLibrary.LibClass;

namespace LesApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // join unicode
            Console.OutputEncoding = Encoding.Unicode;

            // рандомні числа
            Random rnd = new Random();

            // виконання через підключену бібліотеку
            LibClass.LibClassMethod(rnd.Next(0, short.MaxValue),
                rnd.Next(0, short.MaxValue));

            // delay
            Console.ReadKey(true);
        }
    }
}
