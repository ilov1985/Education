//Задайте одномерный массив, 
//заполненный случайными числами.
//Найдите сумму элементов, 
//стоящих на нечётных позициях.

using System;
static class Program
{	
	static void Main()
	{
		int i = 0;
		int sum = 0;
		int N = new Random().Next(3,20);
		int[] array = new int[N];
		Console.WriteLine("Количество элементов массива " + N);
		Console.Write("Массив [ ");
		while(i < N)
		{
			array[i] = new Random().Next(-1000, 1000);
			Console.Write(array[i] + " ");
			if (i%2 != 0) sum += array[i];
			i++;
		}
		Console.WriteLine("]");
		Console.WriteLine("Сумма нечетных элементов массива - " + sum);
	}
}
