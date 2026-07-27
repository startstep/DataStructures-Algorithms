// See https://aka.ms/new-console-template for more information
using System;

class program
{
    public static void Main()
    {
        int[] arr = { 1, 0, 2, 0, 3, 0, 4, 5 };//bubble sort algorithm to move all zeros to the end of the array
        for (int i = 0; i < arr.Length - 1; i++)//its a sorthing algorithm that repeatedly compares adjacent elements
                                                //and swaps them if they are in the wrong order.
                                                //The pass through the list is repeated until the list is sorted.
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                if (arr[j] == 0 && arr[j+1]!=0)
                {
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;

                }

            }
            //  Console.Write(arr[i]);
        }
        foreach (int i in arr)
        {
            Console.Write(i + " ");

        }
    }
}
