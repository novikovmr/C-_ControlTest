/*
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

using System.Runtime.InteropServices.Marshalling;

Console.Clear();

int SizeArray (string msg)
{
    Console.Write(msg);
    int sizeArray = Convert.ToInt32(Console.ReadLine());
    return sizeArray;  
}

void CreateArray(string[] array, int sizeArray)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i+1} элемент массива: ");
        array[i] = Console.ReadLine();

    }
}

int sizeArray = SizeArray("Введите кол-во элементов массива: ");

string[] array = new string[sizeArray];

CreateArray(array, sizeArray);

Console.WriteLine($"[{string.Join(", ", array)}]");
