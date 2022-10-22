// Задача
// Написать программу, которая из имеющегося массива строк формирует 
// массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать 
// на старте выполнения алгориrма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами. 
// Примеры: 
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

string[] GetArray(string[] array)
{
    string[] newArray = new string[0];
    int indexNewArray = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Array.Resize<string>(ref newArray, newArray.Length + 1);
            newArray[indexNewArray] = array[i];
            indexNewArray++;
        }
    }

    return newArray;
}

void PrintArrayToConsole(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}

string[] userArray = new string[5] { "hello", "2", "world", ":-)", "123456" };

string[] newArray = GetArray(userArray);



