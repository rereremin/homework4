string[] array = new string[8];

FillArray(array);
PrintNum(array);
System.Console.Write(" -> ");
PrintArray(array);

////////////////////////////////////////////////////////////////////
void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Console.ReadLine();
}

void PrintNum(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        if(i < array.Length - 1)
            Console.Write(array[i] + ", ");
        else if(i == array.Length - 1)
            System.Console.Write(array[i]);
}

void PrintArray(string[] array)
{
    Console.Write($"[ ");
    for (int i = 0; i < array.Length; i++)
        if(i < array.Length - 1)
            Console.Write(array[i] + ", ");
        else if(i == array.Length - 1)
            System.Console.Write(array[i] + "]");
}
