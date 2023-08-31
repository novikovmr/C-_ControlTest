
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
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
}

int sizeArray = SizeArray("Введите кол-во элементов массива: ");
string[] array = new string[sizeArray];
CreateArray(array, sizeArray);
int countOfChar = CountOfChar(array);
string[] newArray = new string[countOfChar];
ReleaseArray(array, newArray);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"[{string.Join(", ", newArray)}]");
