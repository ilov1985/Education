using System;
class Program
{
    static int CheckLength (int N)
    {
        int check = N;
        int len = 0;
        while (check > 0)
        {
            len++;
            check = check/10;
        }
    return len;
    }

    static void Main (string[] args)
    {
        Console.Write("Введите целое число ");
        int N = Convert.ToInt32(Console.ReadLine());
        int len = CheckLength (N);
        Console.WriteLine("len = " + len);
        if (len > 2)
        {
            if (len == 3)
            {
                Console.WriteLine("Третья цифра числа " + N + " это - " + (N%10));
            } else 
            {
                Console.WriteLine("Третья цифра числа " + N + " это - " + (N/(int)Math.Pow(10, (len - 3))%10));
            }
        } else Console.WriteLine("Введенное число не содержит третьей цифры");
    }
}

//Строковый вариант:
// Console.Write("Введите целое число ");
// string? N = Console.ReadLine();
// if (N.Length < 3) Console.WriteLine("Введенное число не содержит третьей цифры");
// else Console.Write("Третья цифра числа " + N + " это - " + N[2]);