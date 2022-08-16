// Напишите программу, которая
// принимает на вход число и
// выдает сумму цифр в числе.
using System;


static class Program
{
	static void Main()
	{
		Console.Write("Введите число: ");
	    string str = Console.ReadLine();
		int max =  str.Length;
		int sum = 0;
		int str1 = Convert.ToInt32(str);
		for (int i = 0; i < max; i++)
		{
			int tmp = str1 % 10;
			sum = sum + tmp;
			str1 = str1 / 10;
		}
		Console.Write("Сумма цифр числа: " + sum);
	}
}
