// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите первое число: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = int.Parse(Console.ReadLine());

// if(a > b)
// {
//     Console.WriteLine(" max " + a + " min " + b );
// } 
// if(a < b)
// {
//     Console.WriteLine(" max " + b + " min " + a );
// } 

// Вариант 2.

// Console.Write("Введите первое число: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = int.Parse(Console.ReadLine());

// if(a > b)
// {
//     Console.WriteLine(" max " + a + " min " + b );
// } 
// else
// {
//     Console.WriteLine(" max " + b + " min " + a );
// } 


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Вариант 1.

// Console.Write("Введите первое число: ");
// int n1 = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int n2 = int.Parse(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int n3 = int.Parse(Console.ReadLine());

// int max = n1;

// if(max < n2)
// {
//     max = n2;
// }
// if(max < n3)
// {
//     max = n3;
// }
// Console.WriteLine(max);


// Вариант 2.

// Console.Write("Введите первое число: ");
// int n1 = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int n2 = int.Parse(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int n3 = int.Parse(Console.ReadLine());

// int max = n1;

// if(max < n2) max = n2;
// if(max < n3) max = n3;
// Console.WriteLine(max);


// Вариант 3.

// Console.Write("Введите первое число: ");
// int n1 = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int n2 = int.Parse(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int n3 = int.Parse(Console.ReadLine());

// if(n1 > n2 && n1 > n3)
// {
//     Console.WriteLine(" max " + n1);
// }
// if(n2 > n1 && n2 > n3)
// {
//     Console.WriteLine(" max " + n2);
// }
// if(n3 > n1 && n3 > n2)
// {
//     Console.WriteLine(" max " + n3);
// }


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());

// if(number % 2 == 0)
// {
//     Console.WriteLine(number + " - число чётное ");
// }
// else
// {
//     Console.WriteLine(number + " - число нечётное ");
// }


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Write("Введите число ");
// int n = Convert.ToInt32(Console.ReadLine());

// int start = 1;

// while (start <= n)
// {
//     if(start % 2 == 0)
//     Console.Write(start + ", ");
//     start ++;
// }