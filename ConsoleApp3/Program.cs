using System;
using System.Text;
using static System.Console;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass1 = "password";
            pass1 = null;
            // без StringBuilder пароль останется в памяти, хотя ссылку на него утеряем
            // 1 Ввод ФИО (одной строкой)
            // 2 Если пользователь ввел неверные данные, то попросить повторить ввод
            //Верные данные:
            //    - три слова
            //    - каждое слово более трех символов
            //   3 вывести текстовую строку вида "Фамилия:
            bool flag = false;
            string str1;
            while (flag != true)
            {
                WriteLine("Введите ФИО в одну строку через пробел (не менее 3-х символов каждое слово, 3 слова:");
                str1 = ReadLine();
                string[] parts = str1.Split(' ');
                int numflag = 0;
                if (parts.Length != 3) { 
                    WriteLine("Ошибка ввода!");
                    continue; }
                for (int i = 0; i < parts.Length; i++)
                {
                    if (parts[i].Length != 3)
                    {
                        WriteLine("Ошибка ввода!");
                        break;
                    }
                    numflag++;
                }
                if (numflag == 3)
                {
                    flag = true;
                    WriteLine("Фамилия: <" + parts[0] + ">, Имя: <" + parts[1] + "> Отчество:<" + parts[2] + ">");
                }
            }
            
            //string fio = "Ivanov Ivan Ivanivich";
            //// раздление строки по конкретному разделителю
            //string[] parts = fio.Split(' ');
            //WriteLine("F: "+parts[0]);
            //WriteLine("I: " + parts[1]);
            //WriteLine("O: " + parts[2]);
            //// объединение строк
            //fio = parts[0] + ' ' + parts[1] + ' ' + parts[2];
            ////fio="{parts[0]} {parts[1]} {parts[2]}";   // интерполяция
            //WriteLine(fio);
            //// второй способ конкатенации строк
            //string fio2 = string.Join(" ", parts);
            //WriteLine(fio2);
            ////удаление из строки символа h
            //fio2.Trim('h');
            //for (int i = 0; i < 10; i++)
            //{

            //}
            //// StringBuilder позволяет избавиться от копирования
            //StringBuilder stringBuilder = new StringBuilder();
            //var from = DateTime.Now;
            //for (int i = 0; i < 1000; i++)
            //{
            //    stringBuilder.Append(i);
            //}
            //string total = stringBuilder.ToString();
            //var span = from.Subtract(DateTime.Now);
            //WriteLine(total);
            //WriteLine(span.TotalMilliseconds);
            ///// string
            //string str1 = "";
            //for (int i = 0; i < 1000; i++)
            //{
            //    str1+= i; ;
            //}
            //total = str1;
            //span = from.Subtract(DateTime.Now);
            //WriteLine(total);
            //WriteLine(span.TotalMilliseconds);
            ////Конкатенация, интерполяция и шаблоны строк
            //string path = @"c:\windows\Microsoft.Net\assembly",
            //    fileName = "file",
            //    fullPath = path + fileName + ".txt"
            //    ;
            ////интерполяция - средство языка
            //fullPath = $"c:\\windows\\Microsoft.Net\\assembly\\{fileName}.txt";
            //WriteLine(fullPath);
            //// в методе Write вводится "по-своему"
            //Write("Value: {0},value: {1},value: {2}", 10, 10, 20);
            //WriteLine();
            ////способы форматирования текса 
            //// в фигурных скобках позиция в таблице последующего числа , отступ
            //WriteLine("{0,10},{2,10},{1,10}", 10, 10000, 20);
            //WriteLine("{0,10},{1,10},{2,10}", 10000, 10, 20);
            //WriteLine("{0,10},{1,10},{2,10}", 10000, 10000, 200000);
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
