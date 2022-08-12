Console.Write("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int B = N;
int count = 0;
int[] mas = new int[256];
bool flag = true;
while (B > 0.1)
{
    mas[count] = B % 10;
    B = B / 10;
    count++;
}
int index = 0;
while (index < count/2)
{
    if (mas[index] == mas [count-index-1])
    {
        index ++;
    }    
    else
    {
        flag = false;
        break;
    }
}
if (flag) Console.WriteLine("Да, число " + N + " - палиндром");
else Console.WriteLine("Нет, число " + N + " не палиндром");


// Строковый вариант
// Console.Write("Введите целое число: ");
// string? N = Console.ReadLine();
// bool flag = true;
// int i = 0;
// while (i < N.Length/2)
// {
//     if (N[i] == N[N.Length-i-1]) i++;
//     else
//     {
//         flag = false;
//         break;
//     }
// }
// if (flag) Console.WriteLine("Да, число " + N + " - палиндром");
// else Console.WriteLine("Нет, число " + N + " не палиндром");