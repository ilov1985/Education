Console.Write("Введите целое положительное число  ");
int a = Convert.ToInt32(Console.ReadLine());
int index = 1;
Console.Write("Четные числа ");
while (index < a )
{
    if (index%2 == 0) Console.Write(index + " ");
    index++;
}
if (a%2 == 0) Console.Write(a);