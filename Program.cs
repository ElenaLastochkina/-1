//Задача 2: Напишите программу, которая на вход принимает два числа и выдает, 
//какое число большее, а какое меньшее.
//a=5; b=7 max=7
//a=2; b=10 max=10
//a=-9; b=-3 max=-3
Console.WriteLine ("введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("меньшее число; " + number2);
    Console.WriteLine("большее число; " + number1);
}
else
{
    Console.WriteLine("меньшее число; " + number1);
    Console.WriteLine("большее число; " + number2);
}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
// 2,3,7 ->7
// 44,5,78 ->78
// 22,3,9 ->22
Console.WriteLine ("введите первое число");
number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("введите второе число");
number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;

if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}

Console.WriteLine("Максимальное число: " + max);

// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число
// чeтным (делится ли она на два без остатка).
//4 ->да
//-3 ->нет
//7 ->нет
Console.WriteLine ("введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number%2 ==0)
{
    Console.WriteLine ("число четное");
}
else
{
    Console.WriteLine ("число нечетное");
}



// Задача 8: Напишите программу, которая на входе принимает число (N), 
// а на выходе показывает все четные числа от 1 до N
//5 ->2,4
//8 ->2,4,6,8

Console.WriteLine ("введите число");
int numberX = Convert.ToInt32(Console.ReadLine());
int count = 2;

while(count <= numberX)
{
    Console.WriteLine(count + " ");
    count += 2;
}
Console.WriteLine();