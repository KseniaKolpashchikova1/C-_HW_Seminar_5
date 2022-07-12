/* Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */
using System;
using static System.Console;
Clear();

Write("Введите количество элементов массива: ");
int size = int.Parse(ReadLine());

int [] array = GetRandomArray(size, 0, 1000);
Write($"[{String.Join (',', array)}]");
WriteLine();
Write($"{String.Join (',', DifferenceMinNumMaxNum(array))}");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int [] result= new int [size];
    for (int i = 0; i < size; i++)
    {
       result[i] = new Random().Next(minValue, maxValue+1); 
    }
   return result; 
}

int DifferenceMinNumMaxNum (int [] array)
{
    int result = 0;
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
       if(array [i]< min) min = array[i];
       if(array [i]> max) max = array[i];
       {
        result = max - min;
       }
    }
    return result;
}