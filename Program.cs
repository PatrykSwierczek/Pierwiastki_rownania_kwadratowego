Console.WriteLine("Podaj współczynniki równania kwadratowego:");
Console.WriteLine("A:");
double a=double.Parse(Console.ReadLine());
Console.WriteLine("B:");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("C:");
double c = double.Parse(Console.ReadLine());

double dlt = b * b - 4 * a * c;

if (dlt > 0)
{
    double x1 = (-b + Math.Sqrt(dlt)) / (2 * a);
    double x2 = (-b - Math.Sqrt(dlt)) / (2 * a);
    Console.WriteLine("Równanie ma dwa pierwiastki rzeczywiste:");
    Console.WriteLine("x1 = " + x1);
    Console.WriteLine("x2 = " + x2);
}

else if (dlt == 0)
{
    double x = -b / (2 * a);
    Console.WriteLine("Równanie ma jeden pierwiastek rzeczywisty:");
    Console.WriteLine("x = " + x);
}

else
{
    Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych.");
}

Console.ReadLine();