using System;

using Common;

namespace BobbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            DataHelper.Show(BobbleSort(DataHelper.Data));

            Console.WriteLine("Nice!");
        }

        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        static int[] BobbleSort(int[] data)
        {
            for (int i = data.Length - 1; i > -1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        DataHelper.Swap(ref data[j], ref data[j + 1]);
                    }
                }
            }

            return data;
        }


    }
}
