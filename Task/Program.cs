// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равно 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись ислкютительно массивыми._  
// Пример:
//["hello","2","world",":-)"] -> ["2", ":-)"]
//["1234","1567","-2","computer science"] -> ["-2"]
//["Russia", "Denmark","Kazan"]` -> []

//2
string[] ArrayStrings(int size)
{
    string[] arrStr = new string[size];
    Console.WriteLine($"Введите {size} слов(a) для заполения массива");

    for (int i = 0; i < arrStr.Length; i++)  
    {
        string? word = Console.ReadLine();
        if (word != null) arrStr[i] = word;
    }
    return arrStr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}

string[] arrayStrings = ArrayStrings(3);
PrintArray(arrayStrings);


