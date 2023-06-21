// Задача 27: 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите целое число: ");
int Number = int.Parse(Console.ReadLine());


int SumAllDigit(int Number)
{
    int result = 0;
    while (Number > 0)
    {
        result += Number % 10;
        Number = Number / 10;
    }
    return result;
}

Console.WriteLine($"Сумма всех чисел в цифре {Number} = {SumAllDigit(Number)}");