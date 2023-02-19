//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Console.WriteLine("Введите длинну массива ");
int n = int.Parse(Console.ReadLine() ?? "");
string [] m = new string [n];
string [] m1 = new string [n];
NewArray(m);
WriteArray(m);
ResultArray(m,m1);
Console.WriteLine();
WriteArray(m1);
void NewArray (string [] arr)
{
    for (int i = 0; i < n; i++)
    {
        arr[i] = Console.ReadLine() ?? "";
    }
}
void WriteArray (string [] arr)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{arr[i]} ");

    }
}
void ResultArray (string [] arr1, string [] arr2)
{
    int j = 0;
    for (int i = 0; i < n; i++)
    {
        if (arr1[i].Length < 4 )
        {
            arr2[j] = arr1[i];
            j=j+1;
        }

    }
}

