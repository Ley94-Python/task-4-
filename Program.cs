// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= number1; i++)
        
    if (i % 2 == 0) 
                {Console.Write(i + " ");}
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number2; i++)
        
    if (i % 2 == 0) 
                {Console.Write(i + " ");}
