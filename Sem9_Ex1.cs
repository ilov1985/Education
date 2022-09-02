//Задайте значения M и N. 
//Напишите программу, которая 
//выведет все натуральные числа 
//в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""

using System;
static class Program
{
	static void PrintNaturalNums(int min, int max)
	{
		Console.WriteLine($"Натуральные числа на отрезке от {min} до {max}:");
		for (int i = min; i < max + 1; i++)
		{
			Console.Write($"{i} ");
		}
	}
	
	
	static void Main()
	{
		Console.WriteLine("Введите первое число ");
		int m = int.Parse(Console.ReadLine());
		Console.WriteLine("Введите второе число ");
		int n = int.Parse(Console.ReadLine());
		
		if (m < n) PrintNaturalNums(m,n);
		else PrintNaturalNums(n,m);
		
	}
}