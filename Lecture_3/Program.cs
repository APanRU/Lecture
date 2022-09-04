// Метод ничего не принимает и ничего не возвращает
// void Method()
// {
//     Console.WriteLine("Автор...");
// }
// Method();

// Метод принимает на вход аргументы, но ничего не возвращает
// void Method1(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method1(msg: "Текст сообщения");

// void Method11(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;       
//     }
// }
// Method11("Текст сообщения", 4);
// Method11(count: 5, msg: "Привет");

// Метод ничего не принимает, но что-то возвращает
// int Method2()
// {
//     return DateTime.Now.Year;
// }
// int year = Method2();
// Console.WriteLine(year);

// Метод что-то принимает и что-то возвращает
// string Method3(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++
//     }
//     return result;
// }
// string res = Method3(10, "asdf");
// Console.WriteLine(res);

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(3, "0");
// Console.WriteLine(res);

// Цикл в цикле
// for (int i = 2; i <= 10; i++)
//     {
//         for (int j = 1; j <= 10; j++)
//         {
//             Console.WriteLine($"{i} x {j} = {i*j}");
//         } 
//     Console.WriteLine();    
//     }

// Задача на замену символов в тексте
// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";
// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue)
//         {
//            result = result + $"{newValue}";
//         } 
//         else
//         {
//            result =  result + $"{text[i]}";
//         }

//     }
//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// newText = Replace(newText, 'к', 'К' );
// Console.WriteLine(newText);

// Задача упорядочивания данных внутри массива
// int[] arr = {9, 5, 4, 3, 2, 6, 7, 1, 1};

// void PrintArray(int [] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//        Console.Write($"{array[i]} "); 
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] < array[minPosition])
//             {
//                 minPosition = j;
//             }
//         }
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }

// void MaxSort(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         int maxPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] > array[maxPosition])
//             {
//                 maxPosition = j;
//             }
//         }
//         int temporary = array[i];
//         array[i] = array[maxPosition];
//         array[maxPosition] = temporary;
//     }
// }

// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);
// MaxSort(arr);
// PrintArray(arr);