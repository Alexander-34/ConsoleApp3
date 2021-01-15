using System;
using static System.Console;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Конкатенация, интерполяция и шаблоны строк
            string path = @"c:\windows\Microsoft.Net\assembly",
                fileName = "file",
                fullPath = path + fileName + ".txt"
                ;
            //интерполяция - средство языка
            fullPath = $"c:\\windows\\Microsoft.Net\\assembly\\{fileName}.txt";
            WriteLine(fullPath);
            // в методе Write вводится "по-своему"
            Write("Value: {0},value: {1},value: {2}", 10, 10, 20);
            WriteLine();
            //способы форматирования текса 
            // в фигурных скобках позиция в таблице последующего числа , отступ
            WriteLine("{0,10},{2,10},{1,10}", 10, 10000, 20);
            WriteLine("{0,10},{1,10},{2,10}", 10000, 10, 20);
            WriteLine("{0,10},{1,10},{2,10}", 10000, 10000, 200000);
            /*
            // создание текстовых строк
            string[] str1 = new string[3];
            str1[0] = new string(new char[] { 'c', 'z', '1' });
            str1[1] = new string(new char[] { 'c', '1', '2', '3', '4', '5'},2,3);
            str1[2] = new string(new char[] { 'c',4);
            */


        }
    }
}
