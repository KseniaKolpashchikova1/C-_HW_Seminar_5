/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

using System;
using static System.Console;
Clear();

Write("Введите количество элементов массива: ");
int size = int.Parse(ReadLine());
int [] array = GetRandomArray(size, 0, 1000);

Write($"[{String.Join(',', array)}]");
WriteLine();
Write($"{String.Join(',', OddNumberSum(array))}");

int [] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int [size];
    for (int i = 0; i < size; i++)
    {
       result [i] = new Random().Next(minValue, maxValue+1);
    }
    return result;
}

int OddNumberSum(int [] array)
{
    int result =0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] %2 !=0)
        {
            result+= array[i]; 
        }
    }
    return result;
}