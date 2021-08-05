using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numArray = { 10,20, 20, 30, 40, 50,50 };
            int[] numArray = { 10, 20, 30, 40, 50, 60 };
            int result = BinarySearchAlgorithm(numArray, 30);
            if (result == -1)
            {
                Console.WriteLine("Element not found");
            }
            else
            {
                Console.WriteLine("Element found at position :"+result);
            }
            Console.ReadLine();
        }
        public static int BinarySearchAlgorithm(int[] num,int key)
        {
            int min = 0;
            int max = num.Length;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == num[mid])
                {
                    return ++mid;
                }
                else if (key < num[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
    }
}
