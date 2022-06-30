int NumberInput(string text)//Метод ввода и проверки на число
{
    bool isInputInt = true;
    int inputArrayLength = 0;
    while (isInputInt)
    {
        Console.Write($"\nВведите {text} :");
        string numberSTR = Console.ReadLine();
        if (int.TryParse(numberSTR, out int numberInt))
        {
            if ((numberInt > 0) && (numberInt < 10))
            {
                inputArrayLength = numberInt;
                isInputInt = false;
            }
            else
                Console.WriteLine("Введите число из обозначенного диапазона");
        }
        else
            Console.WriteLine("Введите число");
    }
    return inputArrayLength;
}

string[] FillArray(int inputArrayLength) // метод заполнения массива
{
    string[] inputArray = new string[inputArrayLength];
    for (int i = 0; i < inputArrayLength; i++)
    {
        Console.WriteLine("Задайте с клавиатуры элементы массива");
        inputArray[i] = Console.ReadLine();
    }
    return inputArray;
}

string[] MainExample(string[] inputArray) // метод, который проверяет длину элемента изначального массива и в случае, если она меньше либо равна 3, записывает в новый массив
{
    int len = 0;
    string elementInputArray;

    for (int k = 0; k < inputArray.Length; k++) // в результате данного цикла получаем количество символов, длина которых <= 3 и записываем в len
    {
        elementInputArray = inputArray[k];
        if (elementInputArray.Length <= 3)
        {
            len++;
        }
    }

    string[] outputArray = new string[len];
    int index = 0;
    int i = 0;

    while (i < inputArray.Length) 
    {
        if ((inputArray[i]).Length <= 3) // в данном цикле наполняем результирующий массив элементами входного массива, длина которых <= 3
        {
            outputArray[index] = inputArray[i];
            index++;
        }
        i++;
    }

    return outputArray;
}

string Print(string[] array) // метод, который печатает массив
{
    string res = String.Empty;
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        res += $"'{array[i]}' ";
    }
    return res;
}






int inputArrayLength = NumberInput("количество элементов массива в промежутке от 1 до 9 включительно"); // пользователь задаёт количество элементов массива с клавиатуры
string[] inputArray = FillArray(inputArrayLength); // вызываем метод, который позволяет наполнить массив с клавиатуры
string[] outputArray = MainExample(inputArray); // вызываем метод, который наполняет новый массив элементами, длина которых <= 3
Console.WriteLine($"Изначальный массив: {Print(inputArray)} ->  Результирующий массив: {Print(outputArray)}");