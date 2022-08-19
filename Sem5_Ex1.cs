//Задайте массив заполненный 
//случайными положительными 
//трёхзначными числами. Напишите 
//программу, которая покажет
//количество чётных чисел в 
//массиве.

using System;
static class Program
{
    static void Main()
	{
		int i = 0;
		int j = 0;
		int N = new Random().Next(3,100);
		Console.WriteLine("Количество элементов массива:" + N);
		int[] number = new int[N];
		Console.Write("Массив [ ");
		while (i < N)
		{
			number[i] = new Random().Next(100, 999);
			Console.Write(number[i] + " ");
			if (number[i] % 2 == 0)
			{
				j++;
			}
			i++;
		}
		Console.WriteLine("]");
		Console.WriteLine("Четных элементов массива - " + j);
	}
}
