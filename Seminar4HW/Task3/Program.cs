﻿//Задача 3:**Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран.

//1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

void FillArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {

        arr[i] = new Random().Next(1, 100);
    }

}

void OutArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}; ");
    }
}

int[] arr = new int[8];
Console.Clear();
FillArray(arr);
OutArray(arr);