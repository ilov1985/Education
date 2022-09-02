//Напишите программу вычисления
//функции Аккермана с помощью
//рекурсии. Даны два 
//неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29

using System;
static class Program
{
	static double Akkerman(double m, double n)
	{
		double akker = 0;
		if (m == 0)
		{
			akker = n + 1;
		}
		
		if (m > 0 && n == 0)
		{
			akker = Akkerman(m - 1, 1);
		}
		
		if (m > 0 && n > 0)
		{
			akker = Akkerman(m - 1, Akkerman(m, n - 1));
		}
		
		return akker;
	}
	
	
	static void Main()
	{
		Console.Write("Введите число m = ");
		int m = int.Parse(Console.ReadLine());
		Console.Write("Введите второе число n = ");
		int n = int.Parse(Console.ReadLine());
		
		double A = Akkerman(m,n);
		Console.Write($"Значение функции Аккермана A({m},{n}) = {A}");

	}
}