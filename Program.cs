// Задача№1
// Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.

// Пример: 
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Решение
/*
Console.WriteLine("Input 5-digit number" );
int numPol = Convert.ToInt32(Console.ReadLine());

int nUm_Ber = numPol;
int palindrom = 0;
int res = nUm_Ber;

while (res != 0)
{
    int remainder = res % 10;
    Console.Write(remainder);
    palindrom = palindrom * 10 + remainder;
    res /= 10;
}
if (nUm_Ber == palindrom)
{
    Console.Write(" -> да", nUm_Ber);
}
else
{
    Console.Write(" -> нет", nUm_Ber);
}
*/

// Задача№2
// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.

// Пример:
/*
   A (3,6,8); B (2,1,-7), -> 15.84
   A (7,-5, 0); B (1,-1,9) -> 11.53
*/

// Решение:
//   _________________________________________________________
//\/(x1 - x2)(x1 - x2) + (y1 - y2)(y1 - y2) + (с1-с2)(с1-с2)
/*
double NumVer_1 (int x1, int x2, int y1, int y2, int c1, int c2)
{
    double lengthAB =Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2) + (c1-c2)*(c1-c2));
    return lengthAB;
}

Console.WriteLine("input X coordinate of A: ");
int xA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input Y coordinate of A: ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input C coordinate of A: ");
int cA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input X coordinate of B: ");
int xB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input Y coordinate of B: ");
int yB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input C coordinate of B: ");
int cB = Convert.ToInt32(Console.ReadLine());

double res = NumVer_1(xA, yA, cA, xB, yB, cB);

Console.WriteLine($"Distance A{(xA, yA, cA)} B{(xB, yB, cB)} = {res:f3}");
*/

// Задача№3
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// Пример:
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
/*
void Cube ()
{
    Console.WriteLine("Input number: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num >= 1)
    {
        int current_i = 1;
        while (current_i <= num)
        {
            double res =Math.Pow(current_i,3);
            Console.Write($"{res}, ");           
            current_i ++;
        }
        Console.WriteLine("\b\b.");
    }
    else
    {
        int current_i = 1;

        while (current_i >= num)
        {
            Console.Write(current_i * current_i * current_i + ", ");
            current_i --;
        }
        Console.WriteLine("\b\b.");
    }
}
Cube ();
*/
