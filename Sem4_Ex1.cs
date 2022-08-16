//Напишите цикл, который принимает
//на вход два числа (А и В)
using System;

static class Program
{
	static void Main()
	{
		Console.Write("Введите число, которое будем возводить в натуральную степень: ");
	    int a = Convert.ToInt32(Console.ReadLine());
		
        Console.Write("Введите степень: ");
     	int b = Convert.ToInt32(Console.ReadLine());
		
    	double pow = a;
		
    	for (int i = 1;i < b; i++)
    	{
    		pow = pow * a;
    	}
		
    	Console.WriteLine("Результат " + pow);
	}
}