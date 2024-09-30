// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
namespace Prag1
{
    class Files
    {
        public string Name;
        public int Size;
        public string DateMod;
        public string TimeMod;
        public Boolean isDirectory;
        public Files(string name, int size, string datemod, string timemod, Boolean isdir)
        {
            Name = name;
            Size = size;
            DateMod = datemod;
            TimeMod = timemod;
            isDirectory = isdir;
        }
    }
    class MainForm
    {
        static void Draw()
        {
            var InfoList = new List<Files>
            {
                new Files("Lab1hjhjhjj",25,"17.08.2024","20:44",true),
                new Files("Lab4",16,"12.02.2024","20:44", false),
                new Files("Lab2",25,"17.08.2024","20:44", true),
                new Files("Lab4",16,"12.02.2024","20:44", false),
                new Files("Lab5",25,"17.08.2024","20:44", true),
                new Files("Lab6",16,"12.02.2024","20:44", false),
                new Files("Lab7",25,"17.08.2024","20:44", true),
                new Files("Lab8",16,"12.02.2024","20:44", false),
                new Files("Lab9",25,"17.08.2024","20:44", true),
                new Files("Lab10",16,"12.02.2024","20:44", false),
                new Files("Lab11",25,"17.08.2024","20:44", true),
                new Files("Lab12",16,"12.02.2024","20:44", false),
                new Files("Lab13",25,"17.08.2024","20:44", true),
                new Files("Lab14",16,"12.02.2024","20:44", false),
                new Files("Lab15",25,"17.08.2024","20:44", true),
                new Files("Lab16",16,"12.02.2024","20:44", false),
                new Files("Lab17",25,"17.08.2024","20:44", true),
                new Files("Lab18",16,"12.02.2024","20:44", false),
                new Files("Lab5",25,"17.08.2024","20:44", true),
                new Files("Lab6",16,"12.02.2024","20:44", false),
                new Files("Lab7",25,"17.08.2024","20:44", true),
                new Files("Lab8",16,"12.02.2024","20:44", false),
                new Files("Lab9",25,"17.08.2024","20:44", true),
                new Files("Lab10",16,"12.02.2024","20:44", false),
                new Files("Lab11",25,"17.08.2024","20:44", true),
                new Files("Lab12",16,"12.02.2024","20:44", false),
                new Files("Lab13",25,"17.08.2024","20:44", true),
                new Files("Lab14",16,"12.02.2024","20:44", false),
                new Files("Lab15",25,"17.08.2024","20:44", true),
                new Files("Lab16",16,"12.02.2024","20:44", false),
                new Files("Lab17",25,"17.08.2024","20:44", true),
                new Files("Lab18",16,"12.02.2024","20:44", false),
                new Files("Lab17",25,"17.08.2024","20:44", true),
                new Files("Lab18",16,"12.02.2024","20:44", false),
                new Files("Lab5",25,"17.08.2024","20:44", true),
                new Files("Lab6",16,"12.02.2024","20:44", false),
                new Files("Lab7",25,"17.08.2024","20:44", true),
                new Files("Lab8",16,"12.02.2024","20:44", false),
                new Files("Lab9",25,"17.08.2024","20:44", true),
                new Files("Lab10",16,"12.02.2024","20:44", false),
                new Files("Lab11",25,"17.08.2024","20:44", true),
                new Files("Lab12",16,"12.02.2024","20:44", false),
                new Files("Lab13",25,"17.08.2024","20:44", true),
                new Files("Lab14",16,"12.02.2024","20:44", false),
                new Files("Lab15",25,"17.08.2024","20:44", true),
                new Files("Lab16",16,"12.02.2024","20:44", false),
                new Files("Lab17",25,"17.08.2024","20:44", true),
                new Files("Lab18",16,"12.02.2024","20:44", false)
            };
            InfoList.Sort((s1,s2) => s1.Name.CompareTo(s2.Name));
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.SetWindowSize(80, 25);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("     Л");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("евая");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("     Ф");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("айл");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("     Д");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("иск");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("     К");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("оманды");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("     П");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("равая                         ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("8:30");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            //Создание левой рамки
            Console.Write($"\u2554");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"\u2550");
            }
            Console.Write($"\u2564");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"\u2550");
            }
            Console.Write(" C:" + @"\" + "NC ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"\u2550");
            }
            Console.Write($"\u2564");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"\u2550");
            }
            Console.Write($"\u2557");
            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(0, i+2);
                Console.WriteLine($"\u2551");
                Console.SetCursorPosition(11, i + 2);
                Console.WriteLine($"\u2502");
                Console.SetCursorPosition(25, i + 2);
                Console.WriteLine($"\u2502");
                Console.SetCursorPosition(36, i+2);
                Console.WriteLine($"\u2551");
            }
            Console.SetCursorPosition(0, 18);
            Console.Write($"\u255F");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"\u2500");
            }
            Console.Write($"\u2534");
            for (int i = 0; i < 13; i++)
            {
                Console.Write($"\u2500");
            }
            Console.Write($"\u2534");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"\u2500");
            }
            Console.Write($"\u2562");
            Console.SetCursorPosition(0, 19);
            Console.WriteLine($"\u2551");
            Console.WriteLine($"\u255A");
            Console.SetCursorPosition(1, 20);
            for (int i = 0; i < 35; i++)
            {
                Console.Write($"\u2550");
            }
            Console.WriteLine($"\u255D");
            Console.SetCursorPosition(6, 19);
            Console.WriteLine($">КАТАЛОГ< 17.09.2024  19:48");
            Console.SetCursorPosition(36, 19);
            Console.WriteLine($"\u2551");
            //Создание правой рамки
            Console.SetCursorPosition(37, 1);
            Console.Write($"\u2554");
            for (int i = 0; i < 11; i++)
            {
                Console.Write($"\u2550");
            }
            Console.Write($"\u2564");
            for (int i = 0; i < 9; i++)
            {
                Console.Write($"\u2550");
            }
            Console.Write($"\u2564");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"\u2550");
            }
            Console.Write($"\u2564");
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"\u2550");
            }
            Console.Write($"\u2557");
            Console.SetCursorPosition(54, 1);
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(" C:" + @"\" + "NC ");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(37, i + 2);
                Console.WriteLine($"\u2551");
                Console.SetCursorPosition(49, i + 2);
                Console.WriteLine($"\u2502");
                Console.SetCursorPosition(59, i + 2);
                Console.WriteLine($"\u2502");
                Console.SetCursorPosition(70, i + 2);
                Console.WriteLine($"\u2502");
                Console.SetCursorPosition(79, i + 2);
                Console.WriteLine($"\u2551");
            }
            Console.SetCursorPosition(37, 18);
            Console.Write($"\u255F");
            for (int i = 0; i < 11; i++)
            {
                Console.Write($"\u2500");
            }
            Console.Write($"\u2534");
            for (int i = 0; i < 9; i++)
            {
                Console.Write($"\u2500");
            }
            Console.Write($"\u2534");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"\u2500");
            }
            Console.Write($"\u2534");
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"\u2500");
            }
            Console.Write($"\u2562");
            Console.SetCursorPosition(37, 19);
            Console.WriteLine($"\u2551");
            Console.SetCursorPosition(37, 20);
            Console.Write($"\u255A");
            for (int i = 0; i < 41; i++)
            {
                Console.Write($"\u2550");
            }
            Console.WriteLine($"\u255D");
            Console.SetCursorPosition(49, 19);
            Console.WriteLine($">КАТАЛОГ< 17.09.2024  19:48");
            Console.SetCursorPosition(79, 19);
            Console.WriteLine($"\u2551");
            //Запись списка имен
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(5 + i * 12, 2);
                Console.Write("Имя");
            }
            Console.SetCursorPosition(41, 2);
            Console.Write("Имя");
            Console.SetCursorPosition(52, 2);
            Console.Write("Размер");
            Console.SetCursorPosition(62, 2);
            Console.Write("Дата");
            Console.SetCursorPosition(72, 2);
            Console.Write("Время");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < InfoList.Count; i++)
            {
                if (i<15)
                {
                    Console.SetCursorPosition(1, i + 3);
                    if (InfoList[i].Name.Length <= 8)
                    {
                        Console.WriteLine(InfoList[i].Name);
                    }
                    else
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            Console.Write(InfoList[i].Name[j]);

                        }
                        Console.Write("~");
                    }
                }
                else if (i >= 15 && i < 30)
                {
                    Console.SetCursorPosition(12, i + 3-15);
                    if (InfoList[i].Name.Length <= 8)
                    {
                        Console.WriteLine(InfoList[i].Name);
                    }
                    else
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            Console.Write(InfoList[i].Name[j]);

                        }
                        Console.Write("~");
                    }
                }
                else if (i >= 30 && i < 45)
                {
                    Console.SetCursorPosition(26, i + 3-30);
                    if (InfoList[i].Name.Length <= 8)
                    {
                        Console.WriteLine(InfoList[i].Name);
                    }
                    else
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            Console.Write(InfoList[i].Name[j]);

                        }
                        Console.Write("~");
                    }
                }
            }
            //Запись информации о файлах
            for (int i = 0; i < InfoList.Count; i++)
            {
                if (i < 15)
                {
                    Console.SetCursorPosition(38, i + 3);
                    if (InfoList[i].Name.Length <= 8)
                    {
                        Console.WriteLine(InfoList[i].Name);
                    }
                    else
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            Console.Write(InfoList[i].Name[j]);

                        }
                        Console.Write("~");
                    }
                    Console.SetCursorPosition(50, i + 3);
                    if (InfoList[i].isDirectory == true)
                    {
                        Console.WriteLine(">КАТАЛОГ<");
                    }
                    else { Console.WriteLine(InfoList[i].Size); }
                    Console.SetCursorPosition(60, i + 3);
                    Console.WriteLine(InfoList[i].DateMod);
                    Console.SetCursorPosition(73, i + 3);
                    Console.WriteLine(InfoList[i].TimeMod);
                }
            }
            Console.SetCursorPosition(0, 21);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("C:" + @"\" + "NC                                                                           ");
            Console.Write("1");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("Помощь");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" 2");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("Вызов");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" 3");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("Чтение");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" 4");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("Правка");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" 5");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("Копия");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" 6");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("НовИмя");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" 7");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("НовКатал");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" 8");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("Удаление");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" 9");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("Меню");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" 10");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("Выход");
            
        }
        static void Main()
        {
            Draw();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}