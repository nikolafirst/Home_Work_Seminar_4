// Задача 25:
//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


Console.Write("Введите первое число: ");
double FirsNumber = double.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
double SecondNumber = double.Parse(Console.ReadLine());



double result = Math.Pow(FirsNumber, SecondNumber);
Console.WriteLine($"Ответ:" + (result));
