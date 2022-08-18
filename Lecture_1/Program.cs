// Console.Write("Введите Ваше имя: ");
// string username = Console.ReadLine();
// Console.WriteLine("Привет, " + username + "!");

// int numberA = new Random().Next(1,10);
// Console.WriteLine(numberA);
// int numberB = new Random().Next(1,10);
// Console.WriteLine(numberB);
// int result = numberA + numberB;
// Console.WriteLine(result);

// double numberA = 12;
// double numberB = 5;
// double result = numberA / numberB;
// Console.WriteLine(result);

// Console.Write("Введите Ваше имя: ");
// string username = Console.ReadLine();
// if (username.ToLower() == "маша")
// {
//     Console.WriteLine("Ура, это же МАША!");
// }
// else
// {
//      Console.WriteLine("Привет " + username + "!");
// }

// int a = 1;
// int b = 2;
// int c = 6;
// int d = 8;
// int e = 4;
// int max = a;
// if (a > max) max = a;
// if (b > max) max = b;
// if (c > max) max = c;
// if (d > max) max = d;
// if (e > max) max = e;
// Console.WriteLine("Max = " + max);


// Console.Clear();
// int xa = 40, ya = 1;
// int xb = 1, yb = 30;
// int xc = 80, yc = 30;
// Console.SetCursorPosition(xa, ya);
// Console.WriteLine("+");
// Console.SetCursorPosition(xb, yb);
// Console.WriteLine("+");
// Console.SetCursorPosition(xc, yc);
// Console.WriteLine("+");
// int x = xa, y = xb;
// int count = 0;
// while (count < 10000)
// {
//     int what = new Random().Next(0, 3);
//     if (what == 0)
//     {
//         x = (x + xa) / 2;
//         y = (y + ya) / 2;

//     }
//     if (what == 1)
//     {
//         x = (x + xb) / 2;
//         y = (y + yb) / 2;

//     }
//     if (what == 2)
//     {
//         x = (x + xc) / 2;
//         y = (y + yc) / 2;

//     }
//     Console.SetCursorPosition(x, y);
//     Console.WriteLine("+");
//     count++;
// }