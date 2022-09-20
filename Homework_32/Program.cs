using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        const string Exit = "exit";

        bool isDictionaryActive = true;

        Dictionary<string, string> words = new Dictionary<string, string>();
        words.Add("Ассимиляция", "Растворение одного народа в другом.");
        words.Add("Валёжина", "Дерево, упавшее на землю.");
        words.Add("Дефиниция", "Краткое определение какого-либо понятия.");
        words.Add("Диссонанс", "Негармоническое сочетание звуков.");

        Console.WriteLine($"Добро пожаловать в словать!\nДля завершения программы, введите: {Exit}\nНапишите слово, чтобы узнать его значение:");

        while (isDictionaryActive)
        {
            string userInputWord = Console.ReadLine();

            if (words.ContainsKey(userInputWord))
            {
                Console.WriteLine($"Определение: {words[userInputWord]}");
            }
            else if (userInputWord.ToLower() == Exit)
            {
                Console.Clear();
                Console.WriteLine("Работа программы завершена!");
                isDictionaryActive = false;
            }
            else
            {
                Console.WriteLine("Нет такого слова в словаре.");
            }
        }
    }
}