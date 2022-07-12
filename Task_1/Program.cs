/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

using System;
using static System.Console;
Clear();

Write("Введите количество элементов массива: ");
int size = int.Parse(ReadLine());
int [] array = GetRandomArray(size, 0, 1000);

Write($"[{String.Join(",",array)}]");
WriteLine();
Write($"{String.Join(",", (evenNumber(array)))}");

int [] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result=new int[size];
    for (int i = 0; i < size; i++)
    {
       result[i]= new Random().Next (minValue, maxValue+1);
    }
    return result;
}

int evenNumber(int [] array)
{
    int result=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0)
        {
        result++;
        }
    }
    return result;
}
