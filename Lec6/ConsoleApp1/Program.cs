using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World!");

            //Sample 1
            //string s1 = "hello";
            //string s2 = "world";
            //string s3 = $"{s1} {s2}";
            //string s4 = s1 + " " +s2;
            //Console.WriteLine(s3);
            //Console.WriteLine(s4);

            //Sample 2
            //List<string> myList = new List<string>(); 
            //string s1 = "В гостях хорошо, а дома лучше";
            //Console.WriteLine(s1);
            //foreach (string item in s1.Split())
            //{
            //    myList.Add(item);
            //}
            //myList.Sort();
            //string s2 = String.Join(" ",myList.ToArray());
            //Console.WriteLine(s2);

            string path = @"d:\temp";
            string path2 = "d:\\temp\tsecreKey.bin";
            string path3 = $"Путь до временной {path} дирректории: {path}";
            Console.WriteLine(path3);

        }
    }
}
