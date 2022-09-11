Task1

const Double пи = 3.1415;
int k_BackingField;
void set_MyProperty(int value)
{
    int k_BackingField = value;
}
int get_MyProperty()
{
    return k_BackingField;
}

int MyProperty { get; set; }

Task2

void DrawText(string text, int left, int top)
{
    Console.SetCursorPosition(left, top);
    Console.WriteLine(text);
}

string caption = "Intensive c# Demo text";
int screenWidthPosition = (Console.WindowWidth - caption.Length) / 2;
int screenHeightPosition = Console.WindowHeight / 2;

DrawText(caption, screenWidthPosition, screenHeightPosition);

Task3

double a = 1, b = -26, c = 120;
var d = b * b - 4 * a * c;
double x1 = (-b + Math.Sqrt(d)) / (2 * a);
double x2 = (-b - Math.Sqrt(d)) / (2 * a);
Console.WriteLine($"x1 = {x1} x2 = {x2}");

a = 2, b = 1, c = -3;
d = b * b - 4 * a * c;
x1 = (-b + Math.Sqrt(d)) / (2 * a);
x2 = (-b - Math.Sqrt(d)) / (2 * a);
Console.WriteLine($"x1 = {x1} x2 = {x2}");

a = 1, b = 1, c = -6;
d = b * b - 4 * a * c;
x1 = (-b + Math.Sqrt(d)) / (2 * a);
x2 = (-b - Math.Sqrt(d)) / (2 * a);
Console.WriteLine($"x1 = {x1} x2 = {x2}");

public Roots Solve(double a, double b, double c)
{
    var d = b * b - 4 * a * c;
    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
    return new Roots { X1 = x1, X2 = x2 };
}

Solve(1, -26, 120);
Solve(1, 1, -6);
Solve(1, 1, -3);

Task4

Random r = new Random();
Console.CursorVisible = false;
while (true)
{
    Console.SetCursorPosition(
        left: r.Next(Console.WindowWidth),
        top: r.Next(Console.WindowHeight)
        );
    Console.Write(r.Next(10));
    Thread.Sleep(1000);
}

Task5

using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
            .Replace("(", "")
            .Replace(")", "");
Console.WriteLine(text);
Console.WriteLine();
var data = text.Split(" ")
                .Select(item => item.Split(','))
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
                .Where(e => e.x % 2 == 0)
                .Select(point => (point.x * 10, point.y))
                .ToArray();

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
}
