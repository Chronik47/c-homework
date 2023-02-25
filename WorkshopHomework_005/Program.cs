// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int [] GetArray(int size, int minValue, int maxValue)
//     {
//         int[] res = new int[size];
//         for(int i = 0; i < size; i++)
//         {
//             res[i] = new Random().Next(minValue, maxValue + 1);
//         }
//         return res;
//     }

// void PrintArray(int[] inArray)
//     {
//         for ( int i = 0; i < inArray.Length; i++)
//         Console.Write($"{inArray[i]} ");
//     }

// int CountEven(int[] array)
//     {
//     int count = 0;
//         for (int i = 0; i < array.Length; i++)
//         {
//             if (array[i] % 2 == 0)
//             count++;
//         }
//     return count;
//     }

// Console.WriteLine("Введите количество элементов в массиве: ");
// int size = int.Parse(Console.ReadLine());
// int[] array = GetArray(size, 100, 999);
// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine($"Кол-во чётных элементов: {CountEven(array)}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//             Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int [] GetArray(int size, int minValue, int maxValue)
//     {
//         int[] res = new int[size];
//         for(int i = 0; i < size; i++)
//         {
//             res[i] = new Random().Next(minValue, maxValue + 1);
//         }
//         return res;
//     }

// void PrintArray(int[] inArray)
//     {
//         for ( int i = 0; i < inArray.Length; i++)
//         Console.Write($"{inArray[i]} ");
//     }

// int SumOddPositions(int[] array)
//     {
//         int sum = 0;
//         for (int i = 1; i < array.Length; i+=2)
//         {   
//             sum += array[i];
//         }
//         return sum;
//     }

// Console.Write("Введите количество элементов в массиве: ");
// int size = int.Parse(Console.ReadLine());

// Console.Write("Введите минимальный элемент в массиве: ");
// int min = int.Parse(Console.ReadLine());

// Console.Write("Введите максимальный элемент в массиве: ");
// int max = int.Parse(Console.ReadLine());

// int[] array = GetArray(size, min, max);
// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine($"Сумма элементов на нечётных позициях: {SumOddPositions(array)}");



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// double[] GetArray(int size)
//     {
//     double[] res = new double[size];
//         for(int i = 0; i < size; i++)
//         {
//         res[i] = new Random().NextDouble()*10;
//         }
//         return res;
//     }
// void PrintArray(double[] inArray)
//     {
//         for ( int i = 0; i < inArray.Length; i++)
//         Console.Write(Math.Round(inArray[i], 2 )+"; ");
//     }
// double MaxMinusMin (double[] array)
//     {
//     int imin = 0;
//     int imax = 0;
//         for(int i = 0; i < array.Length; i++)
//         {
//         if(array[i] < array[imin])
//           imin = i;

//         if(array[i] > array[imax])
//           imax = i;  
//         }
//         return array[imax] - array[imin];
//     }      

// Console.Write("Введите длину создаваемого массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] array = GetArray(size);
// PrintArray(array);
// Console.WriteLine();
// double result = MaxMinusMin(array);

// Console.Write("Разница между max и min элементом массива: = " + Math.Round(result, 2 ));