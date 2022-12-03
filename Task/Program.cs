// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равно 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись ислкютительно массивыми._  
// Пример:
//["hello","2","world",":-)"] -> ["2", ":-)"]
//["1234","1567","-2","computer science"] -> ["-2"]
//["Russia", "Denmark","Kazan"]` -> []

//МЕТОДЫ
//Метод формирует массив строк с консоли любой длинны.
string[] ArrayStrings()
{
    int size = 0;
    string[] arrStr = new string[size];
    string? word = string.Empty;
    Console.WriteLine($"Введите слова для заполения массива, по окончании ввода нажмите два раза Enter");
    do
    {
        word = Console.ReadLine();
        if (word != "")
        {
            size++;
            string[] arrStrTemp = new string[size];
            for (int i = 0; i < arrStrTemp.Length - 1; i++)
                arrStrTemp[i] = arrStr[i];
                arrStrTemp[size - 1] = word;
                arrStr = arrStrTemp;

        }
    } while (word != "");
    return arrStr;
}

//Метод выводит на печать массив строк.
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

//Метод делает отбор строк из другого массива
string[] SelectionArrayStrings(string[] arrStr, int Length)
{
    int size = 0;
    string[] selArrStr = new string[size];
    string? word = string.Empty;
    
    for (int i = 0; i < arrStr.Length; i++)
    {
        word = arrStr[i];

        if (word.Length <= Length && word.Length > 0)
        {
            size++;
            string[] arrStrtemp = new string[size];

            for (int k = 0; k < arrStrtemp.Length-1; k++)

            arrStrtemp[k] = selArrStr[k];
            arrStrtemp[size - 1] = word;
            selArrStr = arrStrtemp;

        }            
    }
    return selArrStr;
}


string[] arrayStrings = ArrayStrings();
PrintArray(arrayStrings);
Console.WriteLine("");

string[] selectionArrayStrings = SelectionArrayStrings(arrayStrings, 3);
PrintArray(selectionArrayStrings);
