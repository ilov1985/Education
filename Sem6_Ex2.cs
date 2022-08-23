//Напишите программу, которая 
//найдёт точку пересечения двух
//прямых, заданных уравнениями
//y = k1 * x + b1, 
//y = k2 * x + b2; 
//значения b1, k1, b2 и k2 
//задаются пользователем.

using System;
static class Program
{
	static double[] crossPoint(double k1, double b1, double k2, double b2)
	{
		double[] point = new double[2];
		point[0] = (b2 - b1) / (k1 - k2);
		point[1] = k1 * point[0] + b1;
		return point;
	}

	static void Main()
	{
		Console.WriteLine("Программа поиска точки пересечения линий y=k1*x+b1 и y=k2*x+b2");
		Console.Write("Введите значение k1: ");
		double k1 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Введите значение b1: ");
		double b1 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Введите значение k2: ");
		double k2 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Введите значение b2: ");
		double b2 = Convert.ToDouble(Console.ReadLine());
		double[] coord = crossPoint(k1, b1, k2, b2);
		Console.WriteLine("координаиы точки пересечения линий y = " + k1 + "*x+" + b1 + " и y = " + k2 + "*x+" + b2 + ": (" + coord[0] + ";" + coord[1] + ")");
		
	}
}