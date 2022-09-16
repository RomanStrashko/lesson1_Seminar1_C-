// Написать программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N

Console.Write("Введите число N ");
int N = int.Parse(Console.ReadLine());
int a = 1;

while( a <= N)
{
    if( a % 2 == 0 )
    {
    Console.Write($"{a} ");
    }
    a++;
}    
