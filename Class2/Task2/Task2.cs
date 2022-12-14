using System.Security.Cryptography;
using System.Text;

namespace Task2
{
    public class Task2
    {

/*
 * В этих заданиях * рекомендуется всюду использовать класс StringBuilder.
 * Документация: https://docs.microsoft.com/ru-ru/dotnet/api/system.text.stringbuilder?view=net-6.0
 */

/*
 * Задание 2.1. Дана непустая строка S и целое число N (> 0). Вернуть строку, содержащую символы
 * строки S, между которыми вставлено по N символов «*» (звездочка).
 */
        internal static string FillWithAsterisks(string s, int n)
        {
            //TODO: переписать это (с использованием String.PadRight(Int32, char)?)
            string result = "";
            string asterisk = new string('*', n);
            foreach (char c in s)
            {
                result += c + asterisk;
            }

            return result.Substring(0, result.Length - n);
        }

/*
 * Задание 2.2. Сформировать таблицу квадратов чисел от 1 до заданного числа N.
 * Например, для N=4 должна получиться следующая строка:

1  1
2  4
3  9
4 16

 * Обратите внимание на выравнивание: числа в первом столбце выравниваются по левому краю,
 * а числа во втором -- по правому, причём между числами должен оставаться как минимум один
 * пробел. В решении можно использовать функции Pad*.
 */
        internal static string TabulateSquares(int n)
        {
            string result = "";
            int stringLength = n.ToString().Length + (n*n).ToString().Length + 1;
            for (int i = 1; i <= n; ++i)
            {
                result += i.ToString() + (i*i).ToString().PadLeft(stringLength - i.ToString().Length);
                result += i < n ? '\n' : null;
            }

            return result;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(FillWithAsterisks("abc", 2));
            Console.WriteLine(TabulateSquares(100));
        }
    }
}