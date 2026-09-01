using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingProblems
{
    public class ArraySums
    {
        public static int FindMinarr() {
            int [] arr = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };
            if(arr==null || arr.Length == 0)
            {
                throw new ArgumentNullException("Array is empty", nameof(arr));
            }
            int min = arr[0];
            for(int i=1; i < arr.Length-1; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
           
            //for(int i=0;i<arr.Length-1;i++)
            //    for (int j = 0; j < arr.Length - 1; j++)
            //    {
            //    if (arr[j] >= arr[j+1])
            //    {
            //        int temp = arr[j];
            //        arr[j] = arr[j+1];
            //        arr[j+1] = temp;
            //    }
            //}



            //foreach (int num in arr)
            //{
            //    Console.WriteLine(num);
            //}
        }

        public static int MaxInt()
        {
            int[] maxInt = { 8, 1, 2, 3, 5, 4, 9, 3 };
            if(maxInt==null || maxInt.Length == 0)
            {
                throw new ArgumentNullException("Array is null", nameof(maxInt));
            }
            int max = maxInt[0];
            for(int i=1; i<maxInt.Length; i++)
            {
                if (maxInt[i] > max) max = maxInt[i];
            }
            return max;
        }

        public static void  SecondMinandMax()
        {
            int[] arr = { 8, 1, 2, 3, 5, 4, 9, 3 };
            if(arr== null || arr.Length == 0)
            {
                throw new NullReferenceException();
            }
            int min1 = int.MaxValue;  int max1 = int.MinValue;
            int min2 = int.MaxValue;   int max2 = int.MinValue;

            foreach(int num in arr)
            {
                if (num < min1)
                {
                    min2 = min1;
                    min1 = num;
                }
                else if(num>min1 && num < min2)
                {
                    min2 = num;
                }

            }
            foreach(int num in arr)
            {
                if (num > max1)
                {
                    max2 = max1;
                    max1 = num;
                }
                else if(num<max1 && num>max2)
                {
                    max2 = num;
                }
            }

            Console.WriteLine($"Second min is {min2}, Second max is {max2}");
           
        }
        public static void ReverseArray()
        {
            int[] arr = { 2, 3, 5, 4, 9, 1, 8, 0 };
            //  Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length-1; j++)
                {
                    int temp = arr[i];
                    arr[i] = arr[j+1];
                    arr[j + 1] = temp;

                }
            }
            foreach(int num in arr)
            Console.WriteLine(num);
            
        }
        public static void CountFrequency()
        {
            int[] arr = { 5, 7, 2, 2, 5, 5, 7 };
            //Dictionary<int, int> frequency = new Dictionary<int, int>();
            //foreach(int num in arr)
            //{
            //    if (frequency.ContainsKey(num))
            //    {
            //        frequency[num]++;
            //    }
            //    else
            //    {
            //        frequency[num] = 1;
            //    }
            //}
            //foreach(var item in frequency)
            //{
            //    Console.WriteLine($"{item.Key} repeated {item.Value} times");
            //}


        }
    }
}
