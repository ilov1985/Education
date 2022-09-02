//Задайте значения M и N. 
//Напишите программу, которая 
//найдёт сумму натуральных 
//элементов в промежутке от M 
//до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

using System;
static class Program
{
	static void PrintSumNaturalNums(int min, int max)
	{
		Console.WriteLine($"Сумма натуральных чисел на отрезке от {min} до {max}:");
		int sum = 0;
		for (int i = min; i < max + 1; i++)
		{
			sum += i;
		}
		Console.Write(sum);
	}
	
	
	static void Main()
	{
		Console.WriteLine("Введите первое число ");
		int m = int.Parse(Console.ReadLine());
		Console.WriteLine("Введите второе число ");
		int n = int.Parse(Console.ReadLine());
		
		if (m < n) PrintSumNaturalNums(m,n);
		else PrintSumNaturalNums(n,m);
		
	}
}