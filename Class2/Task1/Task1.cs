using System.Text;

namespace Task1
{
    public class Task1
    {
/*
 * Задание 1.1. Дана строка. Верните строку, содержащую текст "Длина: NN",
 * где NN — длина заданной строки. Например, если задана строка "hello",
 * то результатом должна быть строка "Длина: 5".
 */
        internal static int StringLength(string s)
        {
            return s.Length;
        }

/*
 * Задание 1.2. Дана непустая строка. Вернуть коды ее первого и последнего символов.
 * Рекомендуется найти специальные функции для вычисления соответствующих символов и их кодов.
 */
        internal static Tuple<int?, int?> FirstLastCodes(string s)
        {
            return new Tuple<int?, int?>(Code(First(s)), Code(Last(s)));
        }
        
        private static char? First(string s) => s[0];
        private static char? Last(string s) => s[^1];
        private static int? Code(char? c) => (int)c!;
       

/*
 * Задание 1.3. Дана строка. Подсчитать количество содержащихся в ней цифр.
 * В решении необходимо воспользоваться циклом for.
 */
        internal static int CountDigits(string s)
        {
            int result = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                if (Char.IsDigit(s[i]))
                {
                    ++result;
                }
            }

            return result;
        }

/*
 * Задание 1.4. Дана строка. Подсчитать количество содержащихся в ней цифр.
 * В решении необходимо воспользоваться методом Count:
 * https://docs.microsoft.com/ru-ru/dotnet/api/system.linq.enumerable.count?view=net-6.0#system-linq-enumerable-count-1(system-collections-generic-ienumerable((-0))-system-func((-0-system-boolean)))
 * и функцией Char.IsDigit:
 * https://docs.microsoft.com/ru-ru/dotnet/api/system.char.isdigit?view=net-6.0
 */
        internal static int CountDigits2(string s)
        {
            return s.ToCharArray().Count(c => Char.IsDigit(c));
        }
        
/*
 * Задание 1.5. Дана строка, изображающая арифметическое выражение вида «<цифра>±<цифра>±…±<цифра>»,
 * где на месте знака операции «±» находится символ «+» или «−» (например, «4+7−2−8»). Вывести значение
 * данного выражения (целое число).
 */
        internal static int CalcDigits(string expr) {
            int result = (int)Char.GetNumericValue(expr[0]);
            for (int i = 1; i < expr.Length - 1; i += 2)
            {
                if (expr[i] == '+')
                {
                    result += (int)Char.GetNumericValue(expr[i + 1]);
                }
                else
                {
                    result -= (int)Char.GetNumericValue(expr[i + 1]);
                }
            }

            return result;
        }

/*
 * Задание 1.6. Даны строки S, S1 и S2. Заменить в строке S первое вхождение строки S1 на строку S2.
 */
        internal static string ReplaceWithString(string s, string s1, string s2)
        {
            String replaced = s.Substring(0, s.IndexOf(s1) + s1.Length).Replace(s1, s2);
            return replaced + s.Substring(s.IndexOf(s1) + s1.Length);
        }
        

        public static void Main(string[] args)
        {
            Console.WriteLine(StringLength("abc"));
            Console.WriteLine(CountDigits("1a2b3c"));
            Console.WriteLine(FirstLastCodes("xxxxxxxxyyyyyyyy"));
            Console.WriteLine(CalcDigits("2+8-4-7"));
            Console.WriteLine(ReplaceWithString("Миру война", "война", "мир"));
        }
    }
}