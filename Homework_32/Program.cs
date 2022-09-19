using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        const string exit = "exit";
        bool isDictionaryActive = true;

        Dictionary<string, string> word = new Dictionary<string, string>();
        word.Add("Ассимиляция", "Растворение одного народа в другом.");
        word.Add("Валёжина", "Дерево, упавшее на землю.");
        word.Add("Дефиниция", "Краткое определение какого-либо понятия.");
        word.Add("Диссонанс", "Негармоническое сочетание звуков.");

        Console.WriteLine($"Добро пожаловать в словать!\nДля завершения программы, введите: {exit}\nНапишите слово, чтобы узнать его значение:");

        while (isDictionaryActive)
        {
            string userInputWord = Console.ReadLine();

            if (word.ContainsKey(userInputWord))
            {
                Console.WriteLine($"Определение: {word[userInputWord]}");
            }
            else
            {
                Console.WriteLine("Нет такого слова в словаре.");
            }
            if (userInputWord.ToLower() == exit)
            {
                Console.Clear();
                Console.WriteLine("Работа программы завершена!");

                isDictionaryActive = false;
            }
        }
    }
}