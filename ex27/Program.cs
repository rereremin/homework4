int number = NumberFromUser("Введите число: ","Ошибка ввода!");
int sum = SumOfNumbers(number);
System.Console.WriteLine($"{number} -> {sum}");

//////////////
int SumOfNumbers(int FuncNumber)
{
    int result = 0;
    string StrNumber = FuncNumber + String.Empty;
    for (int i = 0; i < StrNumber.Length; i++)
    {
        result = result + number / (int) Math.Pow(10, i) % 10;
    }
    return result;
}

int NumberFromUser(string UserNumber, string MessageError)
{
    while (true)
    {
        System.Console.WriteLine(UserNumber);
        if(int.TryParse(Console.ReadLine(), out int CurrentNumber))
            return CurrentNumber;
        System.Console.WriteLine(MessageError);
    }
}