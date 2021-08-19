using System;

namespace Common
{
    public static class DataHelper
    {
        static int[] data =new int[7] { 4, 5, 3, 6, 2, 5, 1 };
        public static int[] Data 
        { 
            get 
            {
                Show(data);
                return data; 
            } 
        }

        public static void Swap(ref int a, ref int b)
        {
            //int temp = a;
            //a = b;
            //b = temp;

            a ^= b;
            b ^= a;
            a ^= b;
        }

        public static void Show(int[] a)
        {
            foreach (var item in a)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
