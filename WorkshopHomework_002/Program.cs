// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


// Console.WriteLine("Введите трёхзначное число");
// int number = Convert.ToInt32(Console.ReadLine());
// int num = number / 10;
// Console.WriteLine(" Вторая цифра у числа " + number + " -> " + num % 10);



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// if(number > 99)
// {

//     while(number > 999)
//     {
//     number = number / 10;  
//     }
// Console.WriteLine(" Третье число " + "-> " + number % 10);     
// }
// else
// {
//     Console.WriteLine(" Третьего числа нет ");
// }



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

//Вариант 1.

// Console.WriteLine("Введите день недели");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number < 1 || number > 7)
//     Console.WriteLine("Такого дня недели нет");

// else if(number == 6 || number == 7)
//     Console.WriteLine("Это выходной день");

// else
//     Console.WriteLine("Это рабочий день");


// Вариант 2. разные конструкции

// Console.WriteLine("Введите день недели");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number == 6 || number == 7)
// Console.WriteLine("Это выходной день");

// if(number < 1 || number > 7)
// Console.WriteLine("Такого дня недели нет");

// if(number >= 1 && number <= 5)
// Console.WriteLine("Это рабочий день");


