// Написать программу, которая принимает на вход три числа и выдает максимальное из этих чисел

Console.Write("Введите первое число ");
int number = int.Parse(Console.ReadLine());

Console.Write("Введите второе число ");
int number2 = int.Parse(Console.ReadLine());

Console.Write("Введите третье число ");
int number3 = int.Parse(Console.ReadLine());

if(number2 < number) 
if(number > number3)
{
    Console.WriteLine($"Число {number} максимальное число");
}
if(number < number2) 
if(number2 > number3)
{
    Console.WriteLine($"Число {number2} максимальное число");
}
if(number < number3) 
if(number3 > number2)
{
    Console.WriteLine($"Число {number3} максимальное число");
}
