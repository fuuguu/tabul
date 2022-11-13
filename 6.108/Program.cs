//Голубихин Данила 22-ИСП-2/2 Вариант 7
Console.Write("Введите х0: ");
double x0 = double.Parse(Console.ReadLine());
Console.Write("Введите хk: ");
double xk = double.Parse(Console.ReadLine());
Console.Write("Введите dх: ");
double dx = double.Parse(Console.ReadLine());
Console.Write("Введите b: ");
double b = double.Parse(Console.ReadLine());
double x = x0;
while (x <= (xk + dx / 2))
{
    double y = 9*(x+15*Math.Sqrt(Math.Pow(x,3)+Math.Pow(b,3)));
    Console.WriteLine($"| x={x:F2} | y={y:F2} |");
    x+=dx;
}