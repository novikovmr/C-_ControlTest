/*
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

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
        Console.Write($"Введите {i+1}-й элемент массива: ");
        array[i] = Console.ReadLine();

    }
}

int CountOfChar(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

void ReleaseArray(string[] array, string[] newArray)
{
    for (int i = 0; i < array.Length; i++)
    {
        int j = 0;
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
        else j++;
    }
}

int sizeArray = SizeArray("Введите кол-во элементов массива: ");
string[] array = new string[sizeArray];
CreateArray(array, sizeArray);
Console.WriteLine($"[{string.Join(", ", array)}]");
int countOfChar = CountOfChar(array);
string[] newArray = new string[countOfChar];
ReleaseArray(array, newArray);

