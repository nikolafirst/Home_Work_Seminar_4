// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArray(int[] collection)
{
    int lengt = collection.Length;
    int index = 0;
    while (index < lengt)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] collection)
{
    int count = collection.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(collection[position]);
        position++;
    }
}

int [] array = new int[8];
FillArray(array);
PrintArray(array);

