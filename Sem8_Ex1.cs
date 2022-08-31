//Задайте двумерный массив.
//Напишите программу, которая
//упорядочит по убыванию
//элементы каждой строки
//двумерного массива.

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
	
	static void SortStrings(int[,] array)
	{
		int[,] sortArray = new int[array.GetLength(0),array.GetLength(1)];
		int[] row = new int[array.GetLength(1)];
		for(int i = 0; i < array.GetLength(0); i++)
		{
			for(int j = 0; j < array.GetLength(1); j++)
			{
				row[j] = array[i,j];
			}
			int[] newRow = SortRow(row);
			for(int k = 0; k < newRow.Length; k++)
			{
				Console.Write(newRow[k] + " ");
			}
			Console.WriteLine();
		}
	}
	
	static int[] SortRow(int[] row)
	{
		for(int i = 0; i < row.Length; i++)
		{
			int indexMax = i;
			int maxTemp = row[i];
			for(int j = i; j < row.Length; j++)
			{
				if (row[j] > maxTemp)
				{
					maxTemp = row[j];
					indexMax = j;
				}
			}
			row[indexMax] = row[i];
			row[i] = maxTemp;
		}
		return row;
	}
	
	static void Main()
	{
		int[,] array = new int[new Random().Next(3,4), new Random().Next(3,4)];
		array = FillArray(array);
		SortStrings(array);
	}
}