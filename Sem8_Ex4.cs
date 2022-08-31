//Сформируйте трёхмерный массив
//из неповторяющихся двузначных
//чисел. Напишите программу,
//которая будет построчно
//выводить массив, добавляя
//индексы каждого элемента.
//Массив размером 2 x 2 x 2


using System;
static class Program
{
	static void FillArray(int[,,] zeroArray)
	{
		for(int i = 0; i < zeroArray.GetLength(0); i++)
		{
			for(int j = 0; j < zeroArray.GetLength(1); j++)
			{
				for(int k = 0; k < zeroArray.GetLength(1); k++)
				{
					zeroArray[i,j,k] = new Random().Next(10,100);
					Console.Write(zeroArray[i,j,k] + "(" + i + "," + j + "," + k + ") ");
				}	
				Console.WriteLine();
			}
		}
	}
	
	
    static void Main()
    {
        int[,,] array = new int[2,2,2];
        FillArray(array);
    }
}