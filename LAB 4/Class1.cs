using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
    class IntArray
    {
        public int[] _arr;

        public IntArray()
        {
            _arr = new int[0];
        }

        public IntArray(int size)
        {
            _arr = new int[size];
        }

        public int Count
        {
            get { return _arr.Length; }
        }

        //умн массивов
        public static IntArray operator *(IntArray arr1, IntArray arr2)
        {
            IntArray res = new IntArray();
            if (arr1.Count == arr2.Count)
            {
                res = new IntArray(arr1.Count);
                for (int i = 0; i < res.Count; i++)
                    res._arr[i] = arr1._arr[i] * arr2._arr[i];
            }
            return res;
        }

        //истина, если нету отр эл
        public static bool operator true(IntArray arr1)
        {
            int k = 0;
            for (int i = 0; i < arr1.Count; i++)
            {
                if (arr1._arr[i] >= 0)
                {
                    k++;
                }
            }
            if (k == arr1.Count)
            {
                return true;
            }
            else return false;
        }
        public static bool operator false(IntArray arr1)
        {
            int k = 0;
            for (int i = 0; i < arr1.Count; i++)
            {
                if (arr1._arr[i] < 0)
                {
                    k++;
                }
            }
            if (k == arr1.Count)
            {
                return false;
            }
            else return true;
        }

        //размер массива
        public static explicit operator int(IntArray arr1)
        {
            int x = new int();
            x = arr1.Count;
            return x;
        }

        //равенство
        public override bool Equals(object obj)
        {
            IntArray p = (IntArray)obj;
            return (_arr == p._arr);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(_arr);
        }

        //оператор ==
        public static bool operator ==(IntArray arr1, IntArray arr2)
        {
            if (arr1.Count == arr2.Count)
            {
                return arr1.Equals(arr2);
            }
            else return !arr1.Equals(arr2);
        }
        public static bool operator !=(IntArray arr1, IntArray arr2)
        {
            if (arr1.Count == arr2.Count)
            {
                return !arr1.Equals(arr2);
            }
            else return arr1.Equals(arr2);
        }

        //оператор сравнения
        public static bool operator >(IntArray arr1, IntArray arr2)
        {
            if (arr1.Count > arr2.Count)
            {
                return true;
            }
            else return false;
        }
        public static bool operator <(IntArray arr1, IntArray arr2)
        {
            if (arr1.Count < arr2.Count)
            {
                return true;
            }
            else return false;
        }

        // Вывод значений элементов массива на экран
        public void Print()
        {
            Console.Write("Array: ");
            for (int i = 0; i < _arr.Length; i++)
                Console.Write("{0} ", _arr[i]);
            Console.WriteLine();
        }
    }

    //проверка на содержание и удаление
    static class HelpIntArray
    {
        public static bool Proverka(this int[] _arr, int a)
        {
            int k = 0;
            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i] == a)
                {
                    k = 1;
                    break;
                }
            }
            if (k == 1) return true;
            else return false;
        }

        public static int[] Kill(this int[] _arr)
        {
            int size = _arr.Length;
            int m = 0;
            for (int h = 0; h < size; h++)
            {
                if (_arr[h] < 0)
                {
                    m++;
                }
            }
            int[] __arr = new int[size - m];
            int k = 0;
            for (int i = 0; i < size; i++)
            {
                if (_arr[i] >= 0)
                {
                    __arr[k] = _arr[i];
                    k++;
                }
            }
            return __arr;
        }
    }
    public class Owner
    {
        public int Id;
        public string Name;
        public string Company;

        public Owner(int id, string name, string company)
        {
            Id = id;
            Name = name;
            Company = company;
        }

        public Owner own = new Owner(1, "Oleg", "BelSTU");
    }
    public class Date
    {
        public DateTime date_create = new DateTime(2021, 11, 6);
    }
}
