Console.WriteLine("input b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($" X: {x}, Y: {y}");