using System;

class Array
{
    Random rnd = new Random();
    public void arrayGenerate(int[] arr, int length)
    {
        for (int i = 0; i < length; i++)
        {
            arr[i] = rnd.Next();
        }
    }

    public void arrayConcludion(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        /*Array array = new Array();
        int[] arr = new int[5];
        array.arrayGenerate(arr, 5);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }*/
    }
}