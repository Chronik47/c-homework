// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// Console.Clear();

// string UserMessage(string message)                              //Сообщение пользователю.
// {
//     return $"Введите количество {message} >>> ";
// }

// int GetRows()                                                   //Пользователь вводит количество строк.
// {
//     Console.Write($"{UserMessage("строк")}");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     return rows;
// }

// int GetCols()                                                   //Пользователь вводит количество столбцов.
// {
//     Console.Write($"{UserMessage("столбцов")}");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     return columns;
// }

// double[,] RandomArray(int m, int n)
// {
//     double[,] result = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().NextDouble()*(7 + 3) -3;  // Первое число (7) максимальный [диапазон] второе число(-3) минимальный [диапазон].
//         }
//     }
//     return result;
// }

// void PrintArray(double[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write(Math.Round(inArray[i, j], 1 )+"\t ");
//         }
//         Console.WriteLine();
//     }
// }

// void Task47()
// {
//     Console.Clear();
//     int rows = GetRows();
//     int columns = GetCols();
//     double[,] array = RandomArray(rows, columns);
//     PrintArray(array);
// }

// Task47();


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// [1,7] -> по данным индексам такого числа в массиве нет

// Console.Clear();

// string UserMessage(string message)                              
// {
//     return $"Введите количество {message} >>> ";
// }

// int GetRows()                                                   
// {
//     Console.Write($"{UserMessage("строк")}");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     return rows;
// }

// int GetCols()                                                   
// {
//     Console.Write($"{UserMessage("столбцов")}");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     return columns;
// }

// int[,] RandomArray(int m, int n)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(100);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]}\t ");
//         }
//         Console.WriteLine();
//     }
// }

// void FindingAnElement(int[,] array)
// {
// Console.Write("Введите индекс элемента строки: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите индекс элемента столбца: ");
// int b = Convert.ToInt32(Console.ReadLine());

//     if (a >= array.GetLength(0) || b >= array.GetLength(1))
//     {
//     Console.WriteLine($"Под индексами >>> [{a},{b}] числа в массиве нет. ");
//     }
//     else
//     {
//     Console.WriteLine($"Под индексами >>> [{a},{b}] находится число >>> {array[a,b]}. ");     
//     }
// }

// void Task50()
// {
//     Console.Clear();
//     int rows = GetRows();
//     int columns = GetCols();
//     int[,] array = RandomArray(rows, columns);
//     Console.WriteLine();
//     PrintArray(array);
//     Console.WriteLine();
//     FindingAnElement(array);
// }
// Task50();


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Console.Clear();
// string UserMessage(string message)                              
// {
//     return $"Введите количество {message} >>> ";
// }

// int GetRows()                                                   
// {
//     Console.Write($"{UserMessage("строк")}");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     return rows;
// }

// int GetCols()                                                   
// {
//     Console.Write($"{UserMessage("столбцов")}");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     return columns;
// }

// int[,] RandomArray(int m, int n)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(100); // Максимальное значение.
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]}\t ");
//         }
//         Console.WriteLine();
//     }
// }

// void SredneyeArifmeticheskoye(int[,] array) // Среднее арифметическое для каждого столбца.
// {
//     int count = 0;
//     while (count < array.GetLength(1))
//     {
//         double sum = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {   
//             for (int j = count; j < array.GetLength(1); j++)
//             {
//                 if(j == count)
//                 sum = sum + array[i,j];     
//             }  
//         }
//         double sa = sum / array.GetLength(0); 
//         Console.Write($"{Math.Round (sa, 1)}\t");
//         count++;
//     }
// }

// void Task52()
// {
//     Console.Clear();
//     int rows = GetRows();
//     int columns = GetCols();
//     int[,] array = RandomArray(rows, columns);
//     PrintArray(array);
//     Console.WriteLine();
//     SredneyeArifmeticheskoye(array);
// }
// Task52();