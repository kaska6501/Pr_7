//***********************************************************
//* Практическая_7                                          *
//* Выполнила: Абдурахманова Х.Р., группа 2ИСП              *
//* Задание: Заклинание. Цикл for                           *
//***********************************************************
using System;

namespace Практическая_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;

            try
            {
                Console.Write("Здравствуйте! \nВведите количество букв в слове: ");
                int K = Convert.ToInt32(Console.ReadLine());
                string word = " ";
                for (int i = 1; i <= K; i++)
                {
                    int code = (i * i + 3 * i + 7) % 26;
                    char letter = Convert.ToChar(97 + code); // 97 - код буквы a в кодировке ASC||. прибавляем к нему код буквы и преобразуем переменную в char, чтобы получить букву
                    word += letter;  // составляем слово
                    Console.WriteLine($"Позиция {i}: код = {code}, буква = {letter}");
                }
                Console.WriteLine("Заклинание:" + word);
                Console.Write("Введите букву для подсчета: ");
                char letter2 = Convert.ToChar(Console.ReadLine()); // letter2 - буква которую ввел пользователь
                int letter2_code = (Convert.ToInt32(letter2)) - 97; // кодировка которая получится в цикле
                int count = 0; // сколько раз повторяется буква
                for (int i = 1; i <= K; i++)
                {
                    int code = (i * i + 3 * i + 7) % 26;
                    if (code == letter2_code) // сравниваем кодировку буквы пользователя и кодировку букв в заклинании
                        count += 1;
                }
                Console.Write($"Буква {letter2} встретилась {count} раз");
                Console.ReadKey();
            }
            catch (FormatException) // обработка ошибки ввода (класс, производный от базового)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Вы ввели неверное значение!");
            }
            catch (Exception e) // обработка всех ошибок (базовый класс)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Что-то пошло не так. Ошибка: " + e.Message);
            }
        }
    }
} 