Console.Write("Введите трехзначное целое число ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая цифра числа " + N + " это - " + (N%100)/10);

// Строковый вариант:
// Console.Write("Введите трехзначное целое число ");
// string? N = Console.ReadLine();
// Console.Write("Вторая цифра числа " + N + " это - " + N[1]);