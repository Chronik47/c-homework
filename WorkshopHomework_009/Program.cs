// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Clear();
// int N = int.Parse(Console.ReadLine());

// OutputNaturalNumbers(N);    //Вызов метода.

// void OutputNaturalNumbers(int n)
// {
//     if (n != 0)                    //Пока n неравен нулю.                   
//     {
//     Console.Write($"{n} ");
//     OutputNaturalNumbers(n - 1);  //Меняю N = 5 - 1, 4 - 1, 3......
//     }
// }


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Clear();
// Console.Write("Введите первое число ");
// int m = int.Parse(Console.ReadLine());

// Console.Write("Введите второе число ");
// int n = int.Parse(Console.ReadLine());

// Console.WriteLine(SumNaturalElements(m - 1, n));

// int SumNaturalElements(int m, int n)
// {
//     int sum = 0;
//     if (m == n) return 0; 
//     else
//     {
//         m++;
//         sum = m + SumNaturalElements(m, n);
//         return sum;
//     }
    
// }


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
//                                                                                    // n + 1, если m = 0;
// Console.Write("Введите число N: ");                                      // A(m,n) =  A(m - 1, 1), если m != 0, n = 0; 
// int n = Convert.ToInt32(Console.ReadLine());                                       // A(m - 1, A(m, n - 1)), если m > 0; n > 0.

// Console.WriteLine(AkkermanFunction(m, n));

// int AkkermanFunction(int m, int n)
// {
//   if (m == 0)
//     return n + 1;
//   else
//     if (m != 0 && n == 0)
//       return AkkermanFunction(m - 1, 1);
//     else
//       return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
// }
