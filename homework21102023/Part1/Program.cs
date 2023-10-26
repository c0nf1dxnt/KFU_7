using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Part1
{
    internal class Program
    {
        static string ReverseString(string s)
        {

            string result = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                result += s[i];
            }
            return result;
        }
        static bool IsIFormattable(object obj)
        {
            if (obj is IFormattable)
            {
                IFormattable formattable = obj as IFormattable;
                if (formattable != null)
                {
                    return true;
                }
            }
            return false;
        }
        static void SearchMail(ref string s)
        {
            string[] parts = s.Split('#');
            if (parts.Length == 2)
            {
                s = parts[1].Trim();
            }
            else
            {
                s = string.Empty;
            }
        }
        static void Task1()
        {
            Console.WriteLine("Задание №1\nПрограмма переводит деньги с одного аккаунта на другой при помощи метода TransferMoney\n");

            BankAccount account1 = new BankAccount(123m, BankAccount.AccountType.Current);
            BankAccount account2 = new BankAccount(100m, BankAccount.AccountType.Current);
            account1.TransferMoney(account2, 100);
        }
        static void Task2()
        {
            Console.WriteLine("Задание №2\nПрограмма получает на ввод строку и \"разворачивает\" её при помощи метода ReverseString");

            Console.Write("Введите строку: ");
            string inputString = Console.ReadLine();
            Console.WriteLine($"Полученная строка: {ReverseString(inputString)}\n");
        }
        static void Task3()
        {
            Console.WriteLine("Задание №3\nПрограмма проверяет существует ли файл в \\homework21102023\\Part1\\bin\\Debug и переписывает его в другой файл в верхнем регистре, если он существует");

            Console.Write("Введите имя файла: ");
            string fileName = Console.ReadLine();

            if (File.Exists(fileName))
            {
                string newFileName = "output.txt";
                File.WriteAllText(newFileName, File.ReadAllText(fileName).ToUpper());
                Console.WriteLine($"Содержимое файла {fileName} успешно перезаписано верхним регистром в файл {newFileName}\n");
            }
            else
            {
                Console.WriteLine("Файла не существует!\n");
            }
        }
        static void Task4()
        {

            Console.WriteLine("Задание №4\nПрограмма проверяет, реализует ли входной параметр метода интерфейс System.IFormattable");

            object object1 = 17;
            object object2 = "string";
            object object3 = new BankAccount(0m, BankAccount.AccountType.Current);

            Console.WriteLine($"object1 реализует интерфейс IFormattable: {IsIFormattable(object1)}");
            Console.WriteLine($"object2 реализует интерфейс IFormattable: {IsIFormattable(object2)}");
            Console.WriteLine($"object3 реализует интерфейс IFormattable: {IsIFormattable(object3)}\n");
        }
        static void Task5()
        {
            Console.WriteLine("Задание №5\nИзвлечь из файла, находящегося в \\homework21102023\\Part1\\bin\\Debug электронные почты и скопировать их в другой файл\n");

            string inputFileName = "personData.txt";
            string outputFileName = "personEmailsExtracted.txt";

            if (File.Exists(inputFileName))
            {
                string[] lines = File.ReadAllLines(inputFileName);
                File.Delete(outputFileName);
                bool flag = false;

                foreach (string line in lines)
                {
                    string email = line;
                    SearchMail(ref email);

                    File.AppendAllText(outputFileName, email + "\n");
                    flag = true;
                }
                if (flag)
                {
                    Console.WriteLine($"Все адреса электронной почты успешно скопированы в {outputFileName}\n");
                }
                else
                {
                    Console.WriteLine("Возникла ошибка, вероятно файл personData.txt пуст!");
                }
            }
            else
            {
                Console.WriteLine($"Файла {inputFileName} не существует!\n");
            }
        }
        static void Task6()
        {
            Console.WriteLine("Задание №6\nВ методе Main создать список из четырех песен. В\r\nцикле вывести информацию о каждой песне. Сравнить между собой первую и вторую\r\nпесню в списке.");

            List<Song> songs = new List<Song>
            {
            new Song("Smells Like Teen Spirit", "Nirvana"),
            new Song("Notion", "The Rare Occasions"),
            new Song("Still waiting", "Sum 41"),
            new Song("You're Gonna Go Far, Kid", "The Offspring")
            };
            foreach (Song song in songs)
            {
                Console.WriteLine("Название и автор песни: " + song.Title());
                if (song.previousSong != null)
                {
                    Console.WriteLine("Предыдущая песня: " + song.previousSong.Title());
                }
            }
            if (songs[0].CheckForSimilarity(songs[1]))
            {
                Console.WriteLine("Первая и вторая песни - одинаковые!\n");
            }
            else
            {
                Console.WriteLine("Первая и вторая песни разные!\n");
            }
        }
        static void Main()
        {
            Console.Title = "Skynet";
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();

            Console.ReadKey();
        }
    }
}