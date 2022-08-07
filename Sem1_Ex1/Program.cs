Console.Write("Введите целое число a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число b = ");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b)
{
    Console.WriteLine("Числа равны");
}
else if (a > b)
{
    Console.WriteLine("Максимальное число max = " + a);
} 
else 
{
    Console.WriteLine("Максимальное число max = " + b);
}