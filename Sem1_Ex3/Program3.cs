Console.Write("Введите целое число  ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine("Да, число " + a + " делится без остатка на 2");
} 
else
{
    Console.WriteLine("Нет, число " + a + " не делится без остатка на 2");
} 