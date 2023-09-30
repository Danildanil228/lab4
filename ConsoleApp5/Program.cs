Console.Write("Введите координату x: ");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите координату y: ");
double y = double.Parse(Console.ReadLine());
Console.WriteLine(((y > 0 || x < 1) && (y < 1 || x <= 1)) && ((y > 0 || x > -1) && (y < 1 || x >= -1)));
