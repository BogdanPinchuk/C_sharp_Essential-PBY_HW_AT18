#define RELEASE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0
{
    class Program
    {
        static void Main()
        {
            // join unicode
            Console.OutputEncoding = Encoding.Unicode;

            #region Моя прихована область
            Show("\n\tОбласть яка звертається.");
            #endregion

#if DEBUG
            Show("\n\tВерсія Debug.");
#endif

#if NETFRAMEWORK    // не працює https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/preprocessor-directives/preprocessor-if
            Show("\n\tВерсія Release 1");
#else
            Show("\n\tВерсія Release 2");
#endif

#if NETFRAMEWORK && RELEASE // не працює а також NET46 та інші
            Show("\n\tВерсія Release 2");
#endif

#if true
            Show("\n\tЦе виповниться завжди.");
#endif

#line hidden
            Show("\n\tОтладчик не ловить.");
#line default

            // TODO: Задача №0
            // HACK: Задача №1
            // якісь додаткові http://www.cyberforum.ru/csharp-beginners/thread659827.html
            // UNDONE: Задача №2
            // UnresolvedMergeConflict: Задача №3

#warning Попередження від користувача

            // delay
            Console.ReadKey(true);
        }

        private static void Show(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
            Console.ResetColor();
        }
    }
}
