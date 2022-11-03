//Задача 21: 
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double StraightLength (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double length = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    return length;
}


Console.Clear();
Console.WriteLine("Введите координаты первой точки: ");
bool a = int.TryParse(Console.ReadLine(), out int userx1);
bool b = int.TryParse(Console.ReadLine(), out int usery1);
bool c = int.TryParse(Console.ReadLine(), out int userz1);


Console.WriteLine("Введите координаты второй точки: ");
bool d = int.TryParse(Console.ReadLine(), out int userx2);
bool e = int.TryParse(Console.ReadLine(), out int usery2);
bool f = int.TryParse(Console.ReadLine(), out int userz2);


double result = StraightLength(userx1, usery1, userz1, userx2, usery2, userz2);
if (result==0)
{
    Console.WriteLine("error");
}
else
{
    Console.WriteLine(result);
}
