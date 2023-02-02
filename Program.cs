using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTestWork
{

    class Program
    {
        //Ввод исходного массива
        static string[] GetArrayInput(int n)
        {
            string[] array = new string[n];

            Console.WriteLine("Введите строки массива:");
            for (int i = 0; i < n; i++)
                array[i] = Console.ReadLine();

            Console.WriteLine();
            return array;
        }

        //Печать массива
        static void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);

            Console.WriteLine();
        }

        //Подсчет количества строк, удовлетворяющего условию задачи
        static int GetCountArrayInput(string[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
                if (array[i].Length <= 3)
                    count++;

            return count;
        }

        //Формирование результирующего массива
        static string[] GetArrayOutput(string[] array, int n)
        {
            string[] arrayOut = new string[n];
            int j = 0;

            for (int i = 0; i < array.Length; i++)
                if (array[i].Length <= 3)
                {
                    arrayOut[j] = array[i];
                    j++;
                }

            return arrayOut;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество строк в массиве: ");
            int countInputArray = 0;
            int.TryParse(Console.ReadLine(), out countInputArray);
            if (countInputArray <= 0)
            {
                Console.WriteLine("Количество элементов должно быть больше или равно 1!");
                return;
            }
            Console.WriteLine();

            string[] arrayInput = GetArrayInput(countInputArray);

            Console.WriteLine("Исходный массив строк:");
            PrintArray(arrayInput);

            int countOutputArray = GetCountArrayInput(arrayInput);
            if (countOutputArray == 0)
            {
                Console.WriteLine("Строк, длина которых менее или равна 3, не найдено.");
                return;
            }

            string[] arrayOutput = GetArrayOutput(arrayInput, countOutputArray);
            Console.WriteLine("Результирующий массив строк:");
            PrintArray(arrayOutput);
        }
    }
}
