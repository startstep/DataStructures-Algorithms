// See https://aka.ms/new-console-template for more information
using SolvingProblems;
using System;

class Program
{
    public static void Main()
    {
       var rightPointer = new RightPointer();
        int smallerArr = ArraySums.FindMinarr();
        Console.WriteLine(smallerArr);
        int largerArr = ArraySums.MaxInt();
        Console.WriteLine(largerArr);
        ArraySums.SecondMinandMax();
        ArraySums.ReverseArray();
        ArraySums.CountFrequency();
        

    }
}
