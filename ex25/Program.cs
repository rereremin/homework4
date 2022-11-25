int numberA = NumberFromUser("Введите число А: ", "Ошибка ввода!");
int numberB = NumberFromUser("Введите число B: ", "Ошибка ввода!");

int degree = GetNumberDegree(numberA, numberB);
System.Console.WriteLine($"{numberA}, {numberB} -> {degree}");

/////////
int GetNumberDegree(int BaseNumber, int DegreeNumber)
{
    int result = 1;
    for (int i = 0; i <= DegreeNumber; i++)
        result = result * BaseNumber;
    return result;
}

int NumberFromUser(string UserNumber, string MessageError)
{
    while (true)
    {
        System.Console.Write(UserNumber);
        if(int.TryParse(Console.ReadLine(), out int CurrentNumber))
            return CurrentNumber;
        System.Console.WriteLine(MessageError);
    }
}