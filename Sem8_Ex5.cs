//Напишите программу, которая
//заполнит спирально массив 4
//на 4.

using System;
static class Program
{
	static int[,] FillArray(int[,] zeroArray, int rightLimit, int buttomLimit, int startNum)
	{
			for (int i = 0; i < rightLimit; i++)
			{
				zeroArray[0,i] = startNum;
				startNum++;
			}

			for (int j = 1; j < buttomLimit; j++)
			{
				zeroArray[j,rightLimit - 1] = startNum;
				startNum++;
			}

			for (int k = rightLimit - 2; k > 0; k--)
			{
				zeroArray[buttomLimit - 1,k] = startNum;
				startNum++;
			}

			for (int l = buttomLimit - 1; l > 0; l--)
			{
				zeroArray[l,0] = startNum;
				startNum++;
			}

			if (zeroArray.GetLength(0) - 2 > 1)
			{
				if (startNum > (zeroArray.GetLength(0) * zeroArray.GetLength(1))) return zeroArray;
				int[,] newArray = new int[zeroArray.GetLength(0) - 2, zeroArray.GetLength(1) -2];
				newArray = NewArray(zeroArray);
				FillArray(newArray, newArray.GetLength(0), newArray.GetLength(1), startNum);
				zeroArray = CompareArrays(zeroArray, newArray);
				if ((zeroArray.GetLength(0) - 2) % 2 != 0)
				{
					zeroArray[(zeroArray.GetLength(0) / 2), (zeroArray.GetLength(1) / 2)] = zeroArray.GetLength(0) * zeroArray.GetLength(1);
				}
			}
		return zeroArray;
	}
	
	static int[,] NewArray(int[,] array)
	{
		int[,] array1 = new int[array.GetLength(0) - 2, array.GetLength(1) - 2];
		for(int i = 1; i < array.GetLength(0) - 2; i++)
		{
			for(int j = 1; j < array.GetLength(1) - 2; j++)
			{
				array1[i - 1, j - 1] = array[i,j];	
			}
		}
		return array1;
	}
	
	static int[,] CompareArrays(int[,]array, int[,]newArray)
	{
		for(int i = 1; i < array.GetLength(0) - 1; i++)
		{
			for(int j = 1; j < array.GetLength(1) - 1; j++)
			{
				array[i,j] += newArray[i - 1, j - 1];
			}
		}
		return array;
	}
	
	
	static void PrintArray(int[,] array)
	{
		for(int i = 0; i < array.GetLength(0); i++)
		{
			for(int j = 0; j < array.GetLength(1); j++)
			{
				if(array[i,j] / 10 >= 1)
				{
					Console.Write(array[i,j] + "\t  ");
				}
				else
				{
					Console.Write("0" + array[i,j] + "\t  ");
				}
			}
			Console.WriteLine();
		}
	}
	
	static void Main()
	{
		int startNum = 1;
		int N = 4;
		int[,] array = new int[N,N];
		int[] startPoint = new int[]{0,0};
		array = FillArray(array, array.GetLength(0), array.GetLength(1), startNum);
		PrintArray(array);
	}
}