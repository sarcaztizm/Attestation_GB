
Console.Clear();

string [] InputArray (string[] stringArray, int N)
{
    for (int i = 0; i < N; i++)
    {
        stringArray[i] = Convert.ToString(Console.ReadLine());
    }
    return stringArray;
}

void PrintArray (string[] stringArray)
{
    int strLen = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        strLen = stringArray[i].Length;
        if (strLen <= 3)
        {
            Console.Write($"{stringArray[i]}   ");
        }
    }
}

Console.WriteLine("Введите размерность массива:");
int N = Convert.ToInt32(Console.ReadLine());
string [] myArray = new string [N];

Console.WriteLine("Введите строки в массив:");
InputArray(myArray, N);

Console.WriteLine("Результат вывода программы:");
PrintArray(myArray);
