using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
    class Program
    {
        public int[] array;
        public Program(int[] arr)
        {
            array = arr;
        }

        static void Main()
        {
            int k = 0, h = 15, t = -11;
            IntArray first = new IntArray(5);
            IntArray second = new IntArray(5);
            IntArray third = new IntArray(5);
            for (int i = 0; i < 5; i++)
            {
                first._arr[i] = k;
                second._arr[i] = h;
                third._arr[i] = t;
                k++; h += 5; t += 6;
            }
            first.Print();
            second.Print();
            third.Print();
            //умножение
            IntArray four = new IntArray();
            four = first * second;
            four.Print();
            //сравнение массивов
            bool nerav = first < second;
            Console.WriteLine(nerav);
            //проверка на содержание и удаление
            bool f = HelpIntArray.Proverka(first._arr, 4);
            Console.WriteLine(f);
            IntArray five = new IntArray();
            five._arr = HelpIntArray.Kill(third._arr);
            five.Print();
            Console.ReadKey();
        }
    }
}
