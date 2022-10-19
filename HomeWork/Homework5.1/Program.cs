﻿Console.Clear();

void AmountPositiveNums()
{
   
    Console.WriteLine("Введите число для проверки. Для завершения программы введите q.");
    int count = 0;
    int amount = 0;
    while(true)
    {
        Console.Write("Введите число: ");
        string? userInput = Console.ReadLine();
        string stop = "q";
        if(userInput != stop)
        {
            int num = Convert.ToInt32(userInput);
            if (num > 0) count++;
        }
        else 
        {
        Console.WriteLine("Ввод окончен.");
        Console.WriteLine($"Количество положительных чисел = {count}. Всего введено {amount} чисел.");
        break;
        }
        amount++;
    }
}

AmountPositiveNums();
Console.ReadLine();

// Задача №4. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний 
// элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
/*
Console.Clear();

int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("Created array: { ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("}.");
}
/*
int[] ProductElementsArray(int[] array)
{
    int i = 0;
    int size = array.Length;
    int end = array.Length / 2;

    if (size % 2 != 0)
    {
        int length = size / 2 + 1;
        int[] newarray = new int[length];
        while (i < end)
        {
            newarray[i] = array[i] * array[size - 1];
            i++;
            size--;
        }
        newarray[i] = array[end];
        return newarray;
    }
    else
    {
        int count = size / 2;
        int[] newarray = new int[count];
        while (i < end)
        {
            newarray[i] = array[i] * array[size - 1];
            i++;
            size--;
        }
        return newarray;
    }
}
*/
/*
int[] ProductElementsArray(int[] array)
{
    int length = array.Length / 2 + array.Length % 2;
    int[] newArray = new int[length];
    for(int i = 0; i < length; i++)
        if(i != array.Length - i - 1) newArray[i] = array[i] * array[array.Length - i -1];
        else newArray[i] = array[i];
    return newArray;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the minimum element: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the maximum element: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] yourArray = CreateArray(size, minValue, maxValue);
PrintArray(yourArray);
Console.ForegroundColor = ConsoleColor.Green;
int[] result = ProductElementsArray(yourArray);
PrintArray(result);
Console.ReadLine();
*/