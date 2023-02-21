// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArray(int[] arr)
{
    Random rand = new Random();
    for (int i=0; i < arr.Length; i++)
    {
    arr[i]=rand.Next(0,999);
    }  
}

void PrintArray(int[] arr)
{
    for (int i=0; i < arr.Length; i++)
    {
    System.Console.Write(arr[i] + ",");
    }            
}

int [] array = new int[8];

FillArray (array);
PrintArray (array);



