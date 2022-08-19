//Задайте массив вещественных
//чисел. Найдите разницу между 
//максимальным и минимальным
//элементов массива

using System;
static class Program
{	
	static int max(int[] number)
	{
		int max = number[0];
		for (int i1 = 1; i1 < number.Length; i1++)
		{
			if (max < number[i1])
			{
				max = number[i1];
			}
		}
		return max;
	}
	
	static int min(int[] number)
	{
		int min = number[0];
		for (int i2 = 1; i2 < number.Length; i2++)
		{
			if (min > number[i2])
			{
				min = number[i2];
			}
		}
		return min;
	}
	
	
	static void Main()
	{
		int index = 0;
		int rev = 0;
		int N = new Random().Next(3,20);
		int[] array = new int[N];
		Console.WriteLine("Количество элементов массива " + N);
		Console.Write("Массив [ ");
		while(index < N)
		{
			array[index] = new Random().Next(-1000, 1000);
			Console.Write(array[index] + " ");
			index++;
		}
		Console.WriteLine("]");
		rev = max(array) - min(array);
		Console.WriteLine("Разница максимального и минимального элементов массива - " + rev);
	}
}
