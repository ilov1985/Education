//Напишите программу, которая
//задает массив из N элементов
//и выводит их на экран

using System;

static class Program
{
	static void Main()
	{
		Console.Write("Введите количество элементов массива: ");
		int N = Convert.ToInt32(Console.ReadLine());
		int [] array = new int[N];
		for (int i = 0; i < N; i++)
		{
			array[i] = new Random().Next(1, N*10);
			Console.Write(array[i] + " ");
		}
	}
}