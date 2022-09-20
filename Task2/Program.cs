// Написать программу, которая на вход принимает два числа и выдает, какое чило больше, а какое меньше
Console.Write("Введите первое число ");
int number = int.Parse(Console.ReadLine());

Console.Write("Введите второе число ");
int number2 = int.Parse(Console.ReadLine());

if(number < number2)
{
    Console.WriteLine($"Число {number} меньше числа {number2}");
}
else
{    
    if(number > number2)
    {
        Console.WriteLine($"Число {number} больше числа {number2}");
    }
    else
    {
        Console.WriteLine($"Числа равны")
     }
}   
    
