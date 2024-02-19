string[] stringArray = { "elephant", "tiger", "camel", "cat", "dog" };
string[] filteredArray = FilterString(stringArray);

Console.WriteLine("Исходный массив строк: ({0})", string.Join(", ", stringArray));
Console.WriteLine("Отфильтрованный массив строк (длина <= 3): ({0})", string.Join(", ", filteredArray));


string[] FilterString(string[] inputString)
{
    int count = 0;

    // Вычислил количество строк удовлетворяющих условию
    for (int i = 0; i < inputString.Length; i++)
    {
        if (inputString[i].Length <= 3)
        {
            count++;
        }
    }

    // Создал новый массив нужного размера
    string[] resultArray = new string[count];

    // Заполнил новый массив отфильтрованными строками
    int resultIndex = 0;
    for (int i = 0; i < inputString.Length; i++)
    {
        if (inputString[i].Length <= 3)
        {
            resultArray[resultIndex] = inputString[i];
            resultIndex++;
        }
    }

    return resultArray;
}