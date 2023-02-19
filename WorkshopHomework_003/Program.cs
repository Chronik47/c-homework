// Урок 3. Базовые алгоритмы. Продолжение

// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Console.WriteLine("Введите пятизначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int x1 = n / 10000;
// int x2 = n / 1000 % 10;
// int x4 = n % 100 / 10;
// int x5 = n % 10;
// if (x1 == x5 && x2 == x4)
//     Console.WriteLine("palindrome");
// else
//     Console.WriteLine("это не palindrome");

// Console.Clear();
// Console.WriteLine("Введите пятизначное число или слово: ");
// string n = Console.ReadLine();
// int i = 0;
// if (n[0] == n[4] && n[1] == n[3])
//     Console.WriteLine("palindrome");
// else
//     Console.WriteLine("это не palindrome");





// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Clear();
// Console.WriteLine("Введите координату x точки A: ");
// int xA = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату y точки A: ");
// int yA = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату z точки A: ");
// int zA = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату x точки B: ");
// int xB = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату y точки B: ");
// int yB = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату z точки B: ");
// int zB = Convert.ToInt32(Console.ReadLine());

// double AB = (xA - xB) * (xA - xB) +
//         (yA - yB) * (yA - yB) +
//         (zA - zB) * (zA - zB);
//     AB = Math.Sqrt(AB);
// Console.WriteLine(Math.Round (AB, 2));





// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Clear();
// Console.WriteLine("Введите число ");
// int N = Convert.ToInt32(Console.ReadLine());
// int count = 1;

// while (count <= N)
// {
//     int cube = count * count * count;
//     count ++;
// Console.WriteLine(count - 1 + " в кубе = " + cube);   
// }
