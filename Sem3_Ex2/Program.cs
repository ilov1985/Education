using System;

class Program
{

    static double Coord (double c1, double c2)
    {
        double C = Math.Pow(c2 - c1, 2);
        return C;
    }

    static void Main (string[] args)
    {
        Console.WriteLine ("Введите координаты первой точки ");
        Console.Write ("x1 = ");
        double x1 = Convert.ToInt32(Console.ReadLine());
        Console.Write ("y1 = ");
        double y1 = Convert.ToInt32(Console.ReadLine());
        Console.Write ("z1 = ");
        double z1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ("Введите координаты второй точки ");
        Console.Write ("x2 = ");
        double x2 = Convert.ToInt32(Console.ReadLine());
        Console.Write ("y2 = ");
        double y2 = Convert.ToInt32(Console.ReadLine());
        Console.Write ("z2 = ");
        double z2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Расстояние между точками (" + x1 + "," + y1 + "," + z1 + ") и (" + x2 + "," + y2 + "," + z2 + ") равно " + Math.Sqrt(Coord(x1, x2) + Coord(y1,y2) + Coord(z1,z2)));
    }
}