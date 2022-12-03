// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равно 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись ислкютительно массивыми._  
// Пример:
//["hello","2","world",":-)"] -> ["2", ":-)"]
//["1234","1567","-2","computer science"] -> ["-2"]
//["Russia", "Denmark","Kazan"]` -> []

//2
string[] ArrayStrings()
{
    int size = 0;
    string[] arrStr = new string[size];
    string? word = "0";
    Console.WriteLine($"Введите слова для заполения массива, по окончании ввода нажмите два раза Enter");
    do
    {
        word = Console.ReadLine();
        if (word != "")
        {
            size++;
            string[] arrStrTemp = new string[size];
            for (int i = 0; i < arrStrTemp.Length - 1; i++)
            {
                arrStrTemp[i] = arrStr[i];
                arrStrTemp[size - 1] = word;
                arrStr = arrStrTemp;
            }
        }
    } while (word != "") ;
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

string[] 
    string[] arrayStrings = ArrayStrings();
    PrintArray(arrayStrings);

string[] SelectionArrayStrings(string[] arrStr)
{
    int size = 0;
    string[] SelArrStr = new string[size];

    return SelArrStr; 
}

