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
        }
    }
}
