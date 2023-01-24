
string[] strings = InputStringArray();
int numberStrings = InputInt("Введите максимальную длину строки: ");
string[] resultArray = FindStringByLenght(strings, numberStrings);

PrintStringArray(strings, "Исходный массив");
PrintStringArray(resultArray, "Соответствующие критерию строки");

string[] FindStringByLenght(string[] stringArray, int limit)
{
    int size =0;
    string[] resultArray = new string[size];

    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= limit)
        {
            size++;
            Array.Resize(ref resultArray, size);
            resultArray[size-1] = stringArray[i];
        }
    }
    return resultArray;
}

void PrintStringArray(string[] array, string text)
{
    string str = string.Join("; ", array);
    Console.WriteLine($"{text}: [{str}]");
}

string[] InputStringArray()
{
    int length = InputInt("Введите количество элементов: ");
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

int InputInt(string text)
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
