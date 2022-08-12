Console.Write("Введите целое число  ");
int a = Convert.ToInt32(Console.ReadLine());
int index = 0;
Console.Write("Кубы чисел до " + a + ": ");
while (index < a )
{
    Console.Write(Math.Pow(index + 1, 3) + " ");
    index++;
}