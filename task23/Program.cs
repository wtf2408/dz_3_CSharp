Console.Clear();
int [] Method (int n)
{
    int [] array = new int [n];
    for (int i = 0; i < n; i++)
    {
        array[i]  =(i+1)*(i+1)*(i+1);
    }
    return array;
}

void PrintArray(int [] arr)
{
    for (int j = 0; j < arr.Length; j++)
    {
        Console.Write($"{arr[j]} ");
    }
}
Console.WriteLine("Введите число: ");
bool userNumber = int.TryParse(Console.ReadLine(), out int number);
if (number == 0)
{
    Console.WriteLine("Ошибка");
}
else
{
    int [] result = Method (number);
    PrintArray(result);
}
