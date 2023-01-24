
string[] inputArray = InputStringArray();


string[] InputStringArray()
{
    int length = IntData("Введите количество элементов: ");
    string[] array = new string[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = InputString($"Введите элемент №{i}: ");
    }

    return array;
}

string InputString(string text)
{
    Console.Write(text);
    string str = Console.ReadLine();
    return str;
}

int IntData(string text)
{
    bool isParsed = false;
    int number = 0;

    while (!isParsed)
    {
        Console.Write(text);
        isParsed = int.TryParse(Console.ReadLine(), out number);
    }
    return number;
}
