//Задача 37: Найдите 
//произведение пар чисел в 
//одномерном массиве. Парой 
//считаем первый и последний 
//элемент, второй и предпоследний
//и т.д. Результат запишите в 
//новом массиве.

//[1 2 3 4 5] -> 5 8 3

//[6 7 3 6] -> 36 21

using System;
static class Program
{
	static void Main()
	{
		int[] arr1 = new int[new Random().Next(3,10)];
		int[] arr2 = new int[arr1.Length/2 + 1];
		for (int i = 0; i < arr1.Length; i++)
		{
			arr1[i] = new Random().Next(0,10);
			Console.Write(arr1[i] + " ");
		}
		Console.WriteLine(" ");

		for (int j = 0; j < arr2.Length; j++)
		{
			arr2[j] = arr1[j] * arr1[arr1.Length - 1 - j];
			Console.Write(arr2[j] + " ");
			;
		}
		Console.WriteLine(" ");
		
	}	
}