//Задайте двумерный массив
//размером m×n, заполненный
//случайными вещественными
//числами

using System;
static class Program
{
	static void Main()
	{
		Console.WriteLine("Введите размер матрицы случайных чисел");
		Console.Write("Количество строк: ");
		int n = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Количество столбцов: ");
		int m = Convert.ToInt32(Console.ReadLine());
		
		double[,] array = new double[m,n];
		
		Console.WriteLine("Получилась матрица " + n + " x " + m + ":");
		for (int i = 0; i < n; i++)
		{
			for (int j = 0; j < m; j++)
			{
				array[j,i] = new Random().NextDouble();
				Console.Write(Math.Round( array[j,i], 1) + "  \t");
			}
			Console.WriteLine();
		}
	}
}