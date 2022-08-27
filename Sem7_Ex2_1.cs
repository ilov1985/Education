//Напишите программу, которая 
//на вход принимает позиции
//элемента в двумерном массиве,
//и возвращает значение этого
//элемента или же указание,
//что такого элемента нет.

//В соответствии с примером

using System;
class Program
{
	void Main()
	{
		int numRows = 4;
		int numColumns = 4;
		int[,] array = new int[numRows,numColumns];
		
		Console.Write("Введите значение элемента, положение которого требуется найти в матрице:");
		int number = Convert.ToInt32(Console.ReadLine());
		
		bool count = true;
		for (int i = 0; i < numRows; i++)
			{
				for (int j = 0; j < numColumns; j++)
				{
					array[i,j] = new Random().Next(1,100);
					if (array[i,j] == number)
					{
						Console.WriteLine("Найдено в положении (" + i + "," + j + ")");
						count = false;
					}
				}
			}
		if (count) Console.WriteLine("Элемента со значением " + number +" нет в матрице");
	}
}