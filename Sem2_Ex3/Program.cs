Console.WriteLine("Выберите день");
Console.WriteLine(" 1 - Понедельник \n 2 - Вторник \n 3 - Среда \n 4 - Четверг \n 5 - Пятница \n 6 - Суббота \n 7 - Воскресенье");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 6) Console.WriteLine("нет, не выходной");
else Console.WriteLine("да, выходной");