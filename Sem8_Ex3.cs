//Задайте две матрицы. Напишите 
//программу, которая будет 
//находить произведение двух
//матриц.

using System;
static class Program
{
	static int[,] FillArray(int[,] zeroArray)
	{
		for(int i = 0; i < zeroArray.GetLength(0); i++)
		{
			for(int j = 0; j < zeroArray.GetLength(1); j++)
			{
				zeroArray[i,j] = new Random().Next(1,10);
			}
		}
	Console.WriteLine();
	return zeroArray;
	}
    
    static void Print2Arrays(int[,] array1, int[,] array2)
    {
    	string[,]array = new string[array1.GetLength(0), array1.GetLength(1) * 2 + 1];
    	for(int i = 0; i < array.GetLength(0); i++)
    	{
    		for(int j = 0; j < array.GetLength(1)/2; j++)
    		{
    			array[i,j] = Convert.ToString(array1[i,j]);
    			array[i,(j + array1.GetLength(1) + 1)] = Convert.ToString(array2[i,j]);
    		}
    		array[i,array1.GetLength(1)] = "|";
    		for(int k = 0; k < array.GetLength(1); k++)
    		{
    			Console.Write(array[i,k] + "\t");
    		}
    		Console.WriteLine();
    	}
    }
    
    static void MultipleNPrintArrays(int[,]array1, int[,]array2)
    {
    	int[,] multArray = new int[array1.GetLength(0),array1.GetLength(1)];
		for(int i = 0; i < array1.GetLength(0); i++)
    	{
    		for(int j = 0; j < array1.GetLength(1); j++)
    		{
    			multArray[i,j] = MultiplePoint(array1, array2, i, j);
    			Console.Write(multArray[i,j] + "\t ");
    		}
    		Console.WriteLine();
    	}
    }
    
	static int MultiplePoint(int[,]array1, int[,]array2,int i,int j)
	{
		int M = 0;
		for(int k = 0; k < array1.GetLength(0); k++)
		{
			M += array1[i,k] * array2[k,j];
		}
		return M;
	}
    
    static void Main()
    {
		int arrayLength = new Random().Next(2,6);
		int[,] array1 = new int[arrayLength, arrayLength];
		array1 = FillArray(array1);
		int[,] array2 = new int[arrayLength, arrayLength];
		array2 = FillArray(array2);
		Print2Arrays(array1, array2);
 		Console.WriteLine("Результат перемножения матриц:");
		MultipleNPrintArrays(array1,array2);
   }
}