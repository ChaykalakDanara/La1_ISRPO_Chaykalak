// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("Меня зовут Данара");
// Console.WriteLine("16.01.26 11:39");

using System;

namespace backend
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            
            Console.WriteLine($"\nПривет, {name}!");
        }
    }
}