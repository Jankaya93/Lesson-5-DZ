// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равно 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] GetArray()   // запрос на ввод начальных данных
{
    System.Console.WriteLine("Введите элементы массива через пробел: ");
    string[] array = Console.ReadLine().Split(" ").ToArray();
    return array;
}


void PrintArray(string[] array)   // вывод массива в терминал
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int NewLength(string[] array)   // подсчет длины нового массива
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] NewArray(string[] array, int length)   // заполнение нового массива
{
    string[] array2 = new string[length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[j] = array[i];
            j++;
        }
    }
    return array2;
}


var myArray = GetArray();
PrintArray(myArray);

int newLeng = NewLength(myArray);
PrintArray(NewArray(myArray, newLeng));
