// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// double[] CreateArray()
// {
//     Console.Write("Введите длину создаваемого массива: ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     double[] array = new double[size];

//     for(int i = 0; i < size; i++)
//     {
//         Console.Write($"Введите данные {i + 1} элемента массива: ");
//         array[i] = Convert.ToDouble(Console.ReadLine());
//     }
//     return array;    
// }

// void ShowArray(double[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + "\t");

//     Console.WriteLine();
// }

// // Вариант1. 
// int PositiveNumbers1 (double[] array)
// {
// int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0)
//         count ++;
//     }
//     return count;
// }

// // или Вариант2.
// void PositiveNumbers2 (double[] array)
// {
// int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0)
//         count ++;
//     }
//     Console.WriteLine($"Пользователь ввёл количество положительных чисел -> {count}");
// }

// double[] array = CreateArray();
// ShowArray(array);
// Console.WriteLine();
// int result = PositiveNumbers1(array);  //Для Варианта 1.
// Console.WriteLine($"Пользователь ввёл количество положительных чисел -> {result}"); //Для Варианта 1.

// // PositiveNumbers2(array);   //Для Варианта 2.



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



// void PointIntersectionLines(double b1, double k1, double b2, double k2)
// {
//    double x = (b2 - b1) / (k1 - k2);
//    double y = k2 * x + b2;
// Console.WriteLine($"Две прямые пересекаются в точке {x}, {y}");
// }

// Console.WriteLine("Введите значение b1");
// double b1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите значение k1");
// double k1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите значение b2");
// double b2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите значение k2");
// double k2 = Convert.ToInt32(Console.ReadLine());

// PointIntersectionLines(b1, k1, b2, k2);


// double PointIntersectionLinesX(double b1, double k1, double b2, double k2)
// {
//    double x = (b2 - b1) / (k1 - k2);
//    return x;
// }
// double PointIntersectionLinesY(double x, double b2, double k2)
// {
//     double y = k2 * x + b2;
//     return y;
// }

// Console.WriteLine("Введите значение b1");
// double b1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите значение k1");
// double k1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите значение b2");
// double b2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите значение k2");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x = PointIntersectionLinesX(b1, k1, b2, k2);
// double y = PointIntersectionLinesY(x, b2, k2);

// Console.WriteLine($"Две прямые пересекаются в точке {x}, {y}");