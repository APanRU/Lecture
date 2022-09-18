// Task1.Собрать строку с числами от a до b, a<=b

// string NumbersFor (int a, int b)
// {
//     string result = String.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         result += $"{i}";
//     }
//     return result;
// }

// string NumbersForMax(int a, int b)
// {
//     string result = String.Empty;
//     for (int i = b; i >= a; i--)
//     {
//         result += $"{i}";
//     }
//     return result;
// }

// string NumbersRec(int a, int b)
// {
//     if (a <= b) return $"{a}" + NumbersRec(a + 1, b);
//     else return String.Empty;
// }

// string NumbersRecMax(int a, int b)
// {
//     if (a <= b) return NumbersRecMax(a + 1, b) + $"{a}";
//     else return String.Empty;
// }

// Console.WriteLine(NumbersFor(1, 10));
// Console.WriteLine(NumbersRec(1, 10));
// Console.WriteLine(NumbersForMax(1, 10));
// Console.WriteLine(NumbersRecMax(1, 10));

// Task2.Сумма чисел от 1 до n

// int SumFor (int n)
// {
//     int result = 0;
//     for (int i = 1; i <= n; i++) result += i;
//     return result;
// }

// int SumRec(int n)
// {
//     if (n == 0) return 0;
//     else return n + SumRec(n - 1);
// }

// Console.WriteLine(SumFor(10));
// Console.WriteLine(SumRec(10));

// Task3.Факториал числа

// int FactorialFor (int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= i;
//     return result;
// }

// int FactorialForRec(int n)
// {
//     if (n == 0 || n == 1) return 1;
//     else return n * FactorialForRec(n - 1);
// }

// Console.WriteLine(FactorialFor(10));
// Console.WriteLine(FactorialForRec(10));

// Task4.Вичислить a в степени n

// int PowerFor (int a, int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= a;
//     return result;
// }

// int PowerRec(int a, int n)
// {
//     if (n == 0) return 1;
//     else return PowerRec(a, n - 1) * a;
// }

// int PowerRecMath(int a, int n)
// {
//     if (n == 0) return 1;
//     else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
//     else return PowerRec(a, n - 1) * a;
// }

// Console.WriteLine(PowerFor(2, 10));
// Console.WriteLine(PowerRec(2, 10));
// Console.WriteLine(PowerRecMath(2, 10));

// Task5.Перебор слов.
// В некотором машинном алфавите имеются четыре буквы "а", "и", "с" и "в".
//  Покажите все слова, состоящие из Т букв, которые можно построить из букв этого алфавита.

// char[] s = { 'а', 'и', 'с', 'в' };
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//     for (int j = 0; j < count; j++)
//     {
//         Console.WriteLine($"{n++,-5} {s[i]}{s[j]}");
//     }
// }

// int n = 1;

// void FindWords(string alphabet, char[] word, int length = 0)
// {
//     if (length == word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}"); return;
//     }
//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         FindWords(alphabet, word, length + 1);
//     }
// }

// FindWords("аисв", new char[2]);

// Task6.Перебор директорий.

// string path = "/Users/Pankratov_AV/Desktop/Pankratov_AV/geekbrains/BeginCSharp/Lecture/Lecture_1";
// DirectoryInfo di = new DirectoryInfo(path);
// Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
//     Console.WriteLine(fi[i].Name);
// }

// void CatalogInfo(string path, string indent = "")
// {
//     DirectoryInfo catalog = new DirectoryInfo(path);
//     DirectoryInfo[] catalogs = catalog.GetDirectories();
//     for (int i = 0; i < catalogs.Length; i++)
//     {
//         Console.WriteLine($"{indent}{catalogs[i].Name}");
//         CatalogInfo(catalogs[i].FullName, indent + " ");
//     }
//     FileInfo[] files = catalog.GetFiles();
//     for (int i = 0; i < files.Length; i++)
//     {
//         Console.WriteLine($"{indent}{files[i].Name}");
//     }
// }

// CatalogInfo(path);

// Task7.Игра Ханнойская башня.

// void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
// {
//     if (count > 1) Towers(with, some, on, count - 1);
//     Console.WriteLine($"{with} >> {on}");
//     if (count > 1) Towers(some, on, with, count - 1);
// }

// Towers();

// Task8.Обход разных структур

// string emp = String.Empty;
// string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };

// void InOrderTraversal(int pos = 1)
// {
//     if (pos < tree.Length)
//     {
//         int left = 2 * pos;
//         int right = 2 * pos + 1;
//         if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
//         Console.WriteLine(tree[pos]);
//         if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
//     }
// }

// InOrderTraversal();

// Task9.Ряд Фибоначчи.

// decimal fRec = 0;
// decimal fIte = 0;

// decimal FibonacciRecursion(int n)
// {
//     fRec++;
//     return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
// }

// decimal FibonacciInteration(int n)
// {
//     fIte++;
//     decimal result = 1;
//     decimal f0 = 1;
//     decimal f1 = 1;
//     for (int i = 2; i <= n; i++)
//     {
//         result = f0 + f1;
//         f0 = f1;
//         f1 = result;
//         fIte++;
//     }
//     return result;

// }

// Console.ReadLine();
// for (int n = 10; n < 40; n++)
// {
//     Console.WriteLine($"FibonacciInteration({n}) = {FibonacciInteration(n)} fIte = {fIte.ToString("### ### ###"),-15}");
//     fIte = 0;
// }

// Console.WriteLine();

// Console.ReadLine();
// for (int n = 10; n < 40; n++)
// {
//     Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"),-15}");
//     fRec = 0;
// }
// Console.ReadLine();