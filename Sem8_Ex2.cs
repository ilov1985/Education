//Задайте прямоугольный 
//двумерный массив. Напишите 
//программу, которая будет
//находить строку с наименьшей
//суммой элементов.
//Программа считает сумму 
//элементов в каждой строке и 
//выдаёт номер строки с
//наименьшей суммой элементов:
//1 строка

using System;
static class Program
{
	static int[,] FillArray(int[,] zeroArray)
	{
		for(int i = 0; i < zeroArray.GetLength(0); i++)
		{
			for(int j = 0; j < zeroArray.GetLength(1); j++)
			{
				zeroArray[i,j] = new Random().Next(1,10);
				Console.Write(zeroArray[i,j] + " ");
			}
		Console.WriteLine();
		}
	Console.WriteLine();
	return zeroArray;
	}

	static int[] RowSum(int[,] array)
	{
		int[] sum = new int[array.GetLength(0)];
		for(int i = 0; i < array.GetLength(0); i++)
		{
			for(int j = 0; j < array.GetLength(1); j++)
			{
				sum[i] += array[i,j];
			}
				Console.Write(sum[i]+" ");
		}
		return sum;
	}
	
	static void minRow(int[] sum)
	{
		int min = sum[0];
		int minIndex = 0;
		for(int i = 1; i < sum.Length; i++)
		{
			if(sum[i] < min)
			{
				minIndex = i;
			}
		}
		Console.WriteLine("строка " + (minIndex + 1));
	}
	
	
	static void Main()
	{
		int arrayLength = new Random().Next(3,6);
		int[,] array = new int[arrayLength, arrayLength];
		array = FillArray(array);
		int[] rowSum = new int[array.GetLength(0)];
		int[] sum = RowSum(array);
		minRow(sum);
	}
}