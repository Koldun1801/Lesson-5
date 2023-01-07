

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo ski;
            Console.WriteLine("Нажмите на кнопку соответствующую номеру задания в практичекой работе, нумерация начинается с 1");
            while (true)
            {
                ski = Console.ReadKey();

                if (ski.Key == ConsoleKey.D1 || ski.Key == ConsoleKey.NumPad1)
                {
                    Exercise_1();
                    break;
                }

                if (ski.Key == ConsoleKey.D2 || ski.Key == ConsoleKey.NumPad2)
                {
                    Exercise_2();
                    break;
                }
            }
        }

        /// <summary>
        /// первое задание практической работы №5
        /// </summary>
        static void Exercise_1()
        {
            while (true)
            {
                string text;

                Console.WriteLine("\nвведите предложение, которое надо разделить на слова");
                text = Console.ReadLine();

                if (text != null)
                {
                    Write(SplitText(text));
                    break;
                }
            }
        }

        /// <summary>
        /// второе задание практической работы №5
        /// </summary>
        static void Exercise_2()
        {
            while (true)
            {
                string text;

                Console.WriteLine("\nвведите предложение, в котором надо помнять слова местами");
                text = Console.ReadLine();

                if (text != null)
                {
                    Console.WriteLine(ReversWords(text));
                    break;
                }
            }
        }

        /// <summary>
        /// метод разделяющий предложение на слова, возвращает массив слов в формате string
        /// </summary>
        /// <param name="text">разделяемое предложение</param>
        /// <returns></returns>
        static string[] SplitText(string text)
        {
            string[] words = text.Split(' ');
            return words;
        }

        /// <summary>
        /// метод выводящий переменные типа string построчно
        /// </summary>
        /// <param name="words">выводимые переменные</param>
        static void Write(string[] words)
        {
            Console.WriteLine();
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Метод переставляющий слова в предложении (первое последним и т.д.)
        /// </summary>
        /// <param name="inputPhrase"></param>
        static string ReversWords(string inputPhrase)
        {
            string[] words = inputPhrase.Split(' ');
            string result = "";

            for (int i = words.Length - 1; i >= 0; i--)
            {
                result += words[i] + " ";
            }

            return result;
        }
    }
}