//Пользователь вводит с 
//клавиатуры M чисел. 
//Посчитайте, сколько чисел 
//больше 0 ввёл пользователь.

using System;
static class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Введите числа через запятую:");
		string numbers = Console.ReadLine();
		string[] arr = new string[numbers.Length];
		int index = 0;
		foreach (var item in numbers)
		{
			if (Equals (item,','))
			{
				index++;
			}
			else
			{
				arr[index] += item.ToString();
			}
		}
		int[] array = new int[arr.Length];
		int count = 0;
		for (int i = 0; i < arr.Length; i++)
		{
			array[i] = Convert.ToInt32(arr[i]);
			if (array[i] > 0) count++;
		}
		Console.WriteLine("Количество чисел больше 0: " + count);
		
	}
}