//Задайте двумерный массив из 
//целых чисел. Найдите среднее
//арифметическое элементов в
//каждом столбце.

using System;
class Program
{
	static int[] GetArrayFromString(string stringArray)
	{
		string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
		int[] res = new int[nums.Length];
		
		for (int i = 0; i < nums.Length; i++)
		{
			res[i] = int.Parse(nums[i]);
		}
		return res;
	}
	void Main()
	{
		Console.Write("Сколько строк будет в массиве?");
		int numRows = Convert.ToInt32(Console.ReadLine());

		int[,] array = new int[numRows,50];
		
		for (int i = 0; i < numRows; i++)
		{
			Console.WriteLine("Введите строку " + (i + 1) + " массива, разделяя числа пробелом:");
			string stringArray = Console.ReadLine();
			int[] rowArray = GetArrayFromString(stringArray);
			for (int j = 0; j < rowArray.Length; j++)
			{
				array[i,j] = rowArray[j];
			}
		}
		Console.Write("Среднее арифметическое столбцов матрицы: ");
		double[] sum = new double[array.GetLength(1)];
		for (int i = 0; i < array.GetLength(1); i++)
		{
			for (int j = 0; j < array.GetLength(0); j++)
			{
				sum[i] += array[j,i];
			}
			if (sum[i] > 0) Console.Write(Math.Round(sum[i] / numRows, 2) + " ");
		}
	}
}