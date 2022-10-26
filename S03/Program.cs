//Семинар3 Задача23 На вход число (N),выдает кубы чисел от1 до N

/*void Cube(int N)
{
    int a = 1;
    while(a <= N)
    {
        int result = a * a * a;
        Console.Write(result + " ");
        a++;
    }
}
Console.Write("Input a number: ");
int N = Convert.ToInt32(Console.ReadLine());
Cube(N);
*/

//Задача21 На вход координаты 2х точек, находим расстояние между ними в 3D

/*double Distance (double x1, double x2, double y1, double y2, double z1, double z2)
{
    double seg = Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2);
    seg = Math.Sqrt(seg);
    return seg;
}
Console.WriteLine("Input x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double seg = Distance(x1, x2, y1, y2, z1, z2);
Console.WriteLine($"The distance between two dots is {seg}");
*/

//Задача19 На вход 5и значное число и проверяет, является ли оно палиндромом

/*bool Palindrome(int first, int second, int third, int fourth, int fifth)
{
    if (first == fifth & second == fourth)
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.WriteLine("Input first: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second: ");
int second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third: ");
int third = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input fourth: ");
int fourth = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input fifth: ");
int fifth = Convert.ToInt32(Console.ReadLine());

bool result = Palindrome(first, second, third, fourth, fifth);
Console.WriteLine(result);
*/