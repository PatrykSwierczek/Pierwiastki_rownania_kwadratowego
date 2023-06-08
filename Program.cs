Console.WriteLine("Podaj współczynniki równania kwadratowego:");
Console.WriteLine("A:");
double a=double.Parse(Console.ReadLine());
Console.WriteLine("B:");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("C:");
double c = double.Parse(Console.ReadLine());

double dlt = b * b - 4 * a * c;
Console.WriteLine(dlt);
