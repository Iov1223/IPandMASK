using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPandMASK
{
    class Program
    {
        /// <summary>
        /// Метод принимающий значения IP и MASK и проверяющий эти значения на корректность
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="text"></param>
        static void IPandMASK(string []arr, string text)
        {
            Console.WriteLine("Введите " + text + "пооктетно (через \"ENTER\"):");
            bool flag = true;
            for (int i = 0; i < 4; i++)
            {
                do
                {
                    arr[i] = Console.ReadLine();
                    if (Convert.ToInt32(arr[i]) < 0 || Convert.ToInt32(arr[i]) > 255)
                    {
                        Console.WriteLine("Неверный формат. Повторите ввод:");
                        flag = false;
                    }
                    else
                    {
                        flag = true;
                    }
                } while (flag == false);
            }
        }
        /// <summary>
        /// Метод выводящий принятые значения IP и MASK на экран
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="text"></param>
        static void PrintArr(string[] arr, string text)
        {
            string str = string.Join(".", arr);
            Console.WriteLine(text + "= " + str + "\n");
        }
        static void Main(string[] args)
        {
            string ip = "IP ", mask = "MASK ";
            string[] arrIPandMASK = new string[4];
            IPandMASK(arrIPandMASK, ip);
            PrintArr(arrIPandMASK, ip);
            IPandMASK(arrIPandMASK, mask);
            PrintArr(arrIPandMASK, mask);
        }
    }
}
