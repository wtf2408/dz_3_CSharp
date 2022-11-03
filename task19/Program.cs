Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
bool userNumber = int.TryParse(Console.ReadLine(), out int number);
string result = "";
if (number == 0 ||  number>99999 || number < 9999 )
{
   Console.WriteLine("Ошибка, это не пятизначное число"); 
}
else
{
    int [] array = ConvertToArray (number);
    PrintArray(array);
    Console.WriteLine();
    int [] array1 = ConvertToArray1 (number);
    PrintArray(array1);
    string answer = CheckPalindrome(array, array1);
    Console.WriteLine();
    Console.WriteLine(answer);
    
}

string CheckPalindrome (int [] arr, int [] arr1)//проверка на палиндром
{
    for (int x = 0; x < arr.Length; x++)
    {
        if (arr[x]==arr1[x])
        {
            result = "да";
        }
        else
        {
            result = "нет";
        }
    }
    return result;
}

int [] ConvertToArray (int n)//обратный массив
{
    int[] arr = new int[5];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]=n%10;
        n = n/10;
    }
    return arr;
}


int [] ConvertToArray1 (int n)//правильный массив
{
    int[] arr = new int[5];
    for (int i = arr.Length-1; i >=0; i--)
    {
        arr[i]=n%10;
        n = n/10;
    }
    return arr;
}


void PrintArray(int [] arr)//вывод массива
{
    for (int j = 0; j < arr.Length; j++)
    {
        Console.Write($"{arr[j]} ");
    }
}
