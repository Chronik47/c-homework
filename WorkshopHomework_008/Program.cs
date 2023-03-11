// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

// int[,] RandomArray(int rows, int columns)
// {
//     int[,] result = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             result[i, j] = new Random().Next(0, 10);
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

// void SortDescending(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i,k] < array[i,k+1])
//                 {
//                     int temp = array[i,k+1];
//                     array[i,k+1] = array[i,k];
//                     array[i,k] = temp;
//                 }
//             }
//         }
//     }
// }

// void Task54()
// {
// Console.Clear();
// int rows = GetRows();
// int columns = GetCols();
// int[,] array = RandomArray(rows, columns);
// Console.WriteLine();
// PrintArray(array);
// SortDescending(array);
// Console.WriteLine();
// PrintArray(array);
// }
// Task54();


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

// int[,] RandomArray(int rows, int columns)
// {
//     int[,] result = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             result[i, j] = new Random().Next(0, 10);
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

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + "\t");

//     Console.WriteLine();
// }

// int[] SumOfRowElements(int[,] array)
// {
//     int[] arr = new int[array.GetLength(0)];
//     for (int k = 0; k < array.GetLength(0); k++)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             int sum = 0;
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if (i == k)
//                 {
//                 sum += array[i,j];
//                 arr[k] = sum;
//                 }
//             }
//         }
//     }
//     return arr;
// }

// int AmountLineNumber(int[] arr)
// {
//     int imin = 0;
//     for(int k = 0; k < arr.Length; k++)
//     {
//         if(arr[k] < arr[imin])
//         imin = k;
//     }
//     return imin;
// }

// void Task56()
// {
// Console.Clear();
// int rows = GetRows();
// int columns = GetCols();
// int[,] array = RandomArray(rows, columns);
// Console.WriteLine();
// PrintArray(array);
// int[] arr = SumOfRowElements(array);
// Console.WriteLine();
// ShowArray(arr);
// int line = AmountLineNumber(arr);
// Console.WriteLine();
// Console.WriteLine($"Индекс строки с наименьшей суммой элементов -- {line}");
// }
// Task56();


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int Prompt( string message)                           // запрос у пользователя.
// {
//     Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int[,] RandomArray(int rows, int columns)
// {
//     int[,] result = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             result[i, j] = new Random().Next(0, 10);
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
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// bool Validity(int rowB, int colA)
// {
//     if(colA == rowB)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// int[,] ProductOfTwoMatrices(int[,] matrixA, int[,] matrixB)
// {
// int rowA = matrixA.GetLength(0);
// int colB = matrixB.GetLength(1);
// int[,] AB = new int[rowA, colB];
//         for (int i = 0; i < rowA; i++)
//         {
//             for (int j = 0; j < colB; j++)
//             {
//                 for (int k = 0; k < AB.GetLength(1); k++)
//                 {
//                     AB[i, j] += matrixA[i, k] * matrixB[k, j];
//                 }
//             }
//         }
//     return AB;
// }

// Console.Clear();
// int rowsA = Prompt ("Введите количество строк в матрице A: ");
// int columnsA = Prompt ("Введите количество столбцов матрице A: ");
// int rowsB = Prompt ("Введите количество строк в матрице B: ");
// int columnsB = Prompt ("Введите количество столбцов матрице B: ");

// Validity(rowsB, columnsA);
// if(Validity (rowsB, columnsA))
// {
//     int[,] matrixA = RandomArray(rowsA, columnsA);
//     Console.WriteLine("Матрица A");
//     PrintArray(matrixA);
//     Console.WriteLine();
//     int[,] matrixB = RandomArray(rowsB, columnsB);
//     Console.WriteLine("Матрица B");
//     PrintArray(matrixB);
//     Console.WriteLine();
//     int[,] AB = ProductOfTwoMatrices(matrixA, matrixB);
//     Console.WriteLine("Произведение матриц");
//     PrintArray(AB);
// }
// else
// {
//     Console.WriteLine();
//     Console.Write("Произведение двух матриц AB сделать невозможно, потому что число столбцов матрицы А не совпадает с числом строк матрицы В .");
// }

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int Prompt( string message)                           // запрос у пользователя.
// {
//     Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }


// int LengthWidthHeight(int length, int width, int height) // произведение длины, ширины и высоты массива(понадобится для создания одномерного массива).
// {
//     int composition = length * width * height;          // composition -- произведение
//     return composition; 
// }


// int[] NonRepeatingNumbers(int size)                   // одномерный массив с неповторяющимися двузначными числами.
// {
//     int[]array = new int[size];
//     for (int i = 0; i < size; i++)
//     { 
//         int n = new Random().Next(10, 100); 
//         for ( int k = 0; k < i; k++)
//         {   
//             while(n == array[k])
//             {
//             n = new Random().Next(10, 100); 
//             }        
//         }
//         array[i] = n;       
//     }
//     return array;
// }


// void PrintArray1D(int[] mas)                  // печать одномерного массива.
// {            
//    for(int i = 0; i < mas.Length; i++)
//     {
//        Console.Write(mas[i] + ", "); 
//     }
// }


// int[, ,] RandomArray3D(int m, int n, int p, int[] array) //  в трёхмерный массив заливаем одномерный.
// {
//     int[, ,] result = new int[m, n, p];
//     int count = 0;
//     {
//     for (int i = 0; i < m; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {   
//                 for (int z = 0; z < p; z++)
//                 {
//                     result[i, j, z] = array[count];
//                     count++;   
//                 } 
//             }
//         }
//     }
//     return result;
// }

// void PrintArray3D(int[, ,] inArray)                // печать трехмерного массива.       
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             for (int z = 0; z < inArray.GetLength(2); z++)
//             {
//                 Console.Write($"{inArray[i, j, z]}({i},{j},{z}), ");
//             }
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Clear();
// int length = Prompt ("Введите длину массива:");
// int width = Prompt ("Введите ширину массива:");
// int height = Prompt ("Введите высоту массива:");

// int compo = LengthWidthHeight(length, width, height);

// int[]non = NonRepeatingNumbers(compo);
// Console.WriteLine();
// PrintArray1D(non);
// Console.WriteLine();  

// int[, ,] arr = RandomArray3D(length, width, height, non);
// Console.WriteLine();
// PrintArray3D(arr);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int[,] FillArraySpiral(int row, int col)
// {
// int [,] array = new int[row, col];
// int up = 0;     // вверх
// int down = 0;   // вниз
// int left = 0;   // влево
// int right = 0;  // вправо

// int k = 1;  // Счётчик присваивает значение элемента массива
// int i = 0;  // Координата строки
// int j = 0;  // Координата столбца

// while (k <= row * col)
//     {
//     array[i,j] = k;
//                 //проверка движения вправо
//     if (i == up && j < col - right -1)
//         {  
//             j++;    //двигаемся вправо по столбцу
//         }
//                 //проверка движения вниз
//     else if (j == col - right - 1 && i < row - down - 1)
//         {
//             i++;    //двигаемся вниз по строкам
//         }
//                 //проверка движения влево
//     else if (i == row - down -1 && j > left)
//         {
//             j--;    //двигаемся влево по столбцу
//         }
//     else
//         {
//             i--;  //двигаемся вверх по строкам
//         }

//     if((i == up + 1) && (j == left) && (left != col - right - 1)) // != ------> не равно
//         {
//             up++;
//             down++;
//             left++;
//             right++;
//         }
//         k++;
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] SpiralArray = FillArraySpiral(4, 4);
// PrintArray(SpiralArray);
