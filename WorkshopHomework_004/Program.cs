// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


// int Degree(int a, int b)
// {
//     int count = 1;
//     int A = 1;
//     while (count <= b)
//     {
//         A = A * a ;
//         count ++;  
//     }
//     return A;
// }

// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int result = Degree(a, b);
// Console.WriteLine($"{a} в степени {b} = {result}");



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


// int SumDigitsNumber(int num)                                //SumDigitsNumber - СуммаЦифрЧисла.

// {
//     int sum = 0;
//     while(num > 0)
//     {
//         int num1 = num % 10;
//         sum = sum + num1;
//         num = num / 10;
//     }
//     return sum;
// }

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int result = SumDigitsNumber(num);
// Console.WriteLine($"Сумма цифр в числе {num} = {result}");



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


// Из примера я понял, что данные для массива должен задавать пользователь.



// 1.первое

// int[] CreateArray()
// {
//     Console.Write("Введите длину создаваемого массива: ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//     {
//         Console.Write($"Введите данные {i + 1} элемента массива: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// int[] myArray = CreateArray();
// ShowArray(myArray);



// 2.второе

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//     {
//         Console.Write("Введите элемент массива: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// Console.Write("Введите длину создаваемого массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateArray(size);
// ShowArray(myArray);
