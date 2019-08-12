using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Моя бібліотека
/// </summary>
namespace MyLibrary
{
    /// <summary>
    /// Бібліотечний клас
    /// </summary>
    public static class LibClass
    {
        public static void LibClassMethod(int a, int b)
        {
            Console.WriteLine($"\n\t{a:N0} + {b:N0} = {a + b:N0}");
        }
    }
}
