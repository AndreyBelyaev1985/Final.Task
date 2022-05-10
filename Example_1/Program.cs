/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символа. Первоночальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> [ ]
*/


void Prompt(string[] array) // ввод элементов массива строк пользователем
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"\nВведите строку массива под индексом {i}:\t ");
        array[i] = Console.ReadLine()!;
    }
}

void PrintArray(string[] array) // вывод  заданного пользователем массива строк
{
    Console.Write("{");

    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("}");

}

void SortArray(string[] array) // сортировка массива по длине элемента
{
    Console.Write("{");
    for (int i = 0; i < array.Length; i++)
    {
        string text = String.Empty;
        text = array[i];

        int length = text.Length;

        string result = String.Empty;

        for (int j = 0; j < length; j++)
        {
            if (length < 4)
            {
                result = result + $"{text[j]}";
            }
            else break;
        }
        Console.Write($"{result}" + " ");
        //System.Console.Write(", ");
    }
    Console.Write("}");
}


Console.Write("Введите количество строк в массиве: \t");
int lines = int.Parse(Console.ReadLine()!);

string[] ArrString = new string[lines];
Prompt(ArrString);
Console.Write($"\nВывод заданного массива: ");
PrintArray(ArrString);
Console.WriteLine();
Console.Write("\nВвывод отсортированного массива: ");
SortArray(ArrString);
