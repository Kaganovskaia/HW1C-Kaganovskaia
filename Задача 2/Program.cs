/* Напишите программу, которая на вход принимает два числа 
и выдает, какое число большее, а какое меньшее */
int number1;
int number2;
Console.WriteLine("Введите первое число ");
number1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
number2=Convert.ToInt32(Console.ReadLine());
if (number1>number2);
{
    Console.WriteLine($"Первое число {number1} большее, второе число {number2} меньшее");
};
if (number1==number2);
{
    Console.WriteLine($"Введенные числа не могут быть одинаковыми");
};


