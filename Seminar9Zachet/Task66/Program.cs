﻿/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


using System;
using static System.Console;

Clear();

int m = Get_int("Введите M: ");
int n = Get_int("Введите N: ");
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}
PrintSumm(m, n, temp = 0);

void PrintSumm(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов = {sum} ");
        return;
    }
    PrintSumm(m, n - 1, sum);
}

int Get_int(string message)
{
    Write(message);
    return int.Parse(ReadLine());
}