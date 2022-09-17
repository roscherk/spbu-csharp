namespace Task4
{
    public class Task4
    {
/*
 * В решениях следующих заданий предполагается использование циклов.
 */

/*
 * Задание 4.1. Пользуясь циклом for, посимвольно напечатайте рамку размера width x height,
 * состоящую из символов frameChar. Можно считать, что width>=2, height>=2.
 * Например, вызов printFrame(5,3,'+') должен напечатать следующее:

+++++
+   +
+++++
 */

        internal static void PrintLine(int width, int height, char frameChar, bool full)
        {
            Console.Write(frameChar);
            
            for (int j = 0; j < width - 2; ++j)
            {
                Console.Write(full ? frameChar : ' ');
            }
            
            Console.Write($"{frameChar}\n");
        }
        internal static void PrintFrame(int width, int height, char frameChar = '*')
        {
            PrintLine(width, height, frameChar, true);  // печатаем первую строчку
            
            for (int i = 0; i < height - 2; ++i)  // печатаем строчки со второй до предпоследней
            {
                PrintLine(width, height, frameChar, false);
            }
            
            PrintLine(width, height, frameChar, true);  // печатаем последнюю строчку
        }

/*
 * Задание 4.2. Выполните предыдущее задание, пользуясь циклом while.
 */
        internal static void PrintFrame2(int width, int height, char frameChar = '*')
        {
            int i = 0;
            
            PrintLine(width, height, frameChar, true);
            ++i;

            while (i < height - 1)
            {
                PrintLine(width, height, frameChar, false);
                ++i;
            }
            
            PrintLine(width, height, frameChar, true);
        }


/*
 * Задание 4.3. Даны целые положительные числа A и B. Найти их наибольший общий делитель (НОД),
 * используя алгоритм Евклида:
 * НОД(A, B) = НОД(B, A mod B),    если B ≠ 0;        НОД(A, 0) = A,
 * где «mod» обозначает операцию взятия остатка от деления.
 */
        internal static long Gcd(long a, long b)
        {
            if (a == 0 || b == 0)
            {
                return a + b;
            }

            return a > b ? Gcd(b, a % b) : Gcd(a, b % a);
        }

/*
 * Задание 4.4. Дано вещественное число X и целое число N (> 0). Найти значение выражения
 * 1 + X + X^2/(2!) + … + X^N/(N!), где N! = 1·2·…·N.
 * Полученное число является приближенным значением функции exp в точке X.
 */
        internal static double ExpTaylor(double x, int n)
        {
            double result = 1;
            double currentFactorial = 1;
            
            for (int i = 1; i <= n; ++i)
            {
                result += Math.Pow(x, i) / currentFactorial;
                currentFactorial *= (i + 1);
            }
            
            return result;
        }

        public static void Main(string[] args)
        {
            PrintFrame(8, 5, '+');
            PrintFrame2(8, 5, '+');
            Console.WriteLine(ExpTaylor(2.0, 1000));
        }
    }
}