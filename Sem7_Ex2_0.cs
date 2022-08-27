//Напишите программу, которая 
//на вход принимает позиции
//элемента в двумерном массиве,
//и возвращает значение этого
//элемента или же указание,
//что такого элемента нет.

//В соответствии с заданием

using System;
class Program
{
	void Main()
	{
		int numRows = 4;
		int numColumns = 4;
		int[,] array = new int[numRows,numColumns];
		
		Console.WriteLine("Введите положение элемента в матрице:");
		Console.Write("строка: ");
		int row = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("столбец: ");
		int column = Convert.ToInt32(Console.ReadLine());
		
		if (row > numRows || column > numColumns)
		{
			Console.WriteLine("Элемента с положением (" + row +"," + column +") нет в матрице");
		}
		else
		{
			for (int i = 0; i < numRows; i++)
			{
				for (int j = 0; j < numColumns; j++)
				{
					array[i,j] = new Random().Next(1,100);
					if ((i == row) && (j == column))
					{
						Console.WriteLine("В положении (" + row + "," + column + ") находится число " + array[row,column]);
					}
				}
			}
		}
	}
}