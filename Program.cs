// Задача 1
Console. WriteLine("Введи A:");
int number1 = int. Parse(Console.ReadLine()!);
Console. WriteLine("Введи B:");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 > number2)
{
    Console.WriteLine( "Число {A} больше числа {B}");
}
if (number2 > number1)
{
    Console.WriteLine( "Число {B} больше числа {A}");}
else
{
  Console.WriteLine( "Число {B} равно числу {A}");  
}

// Задача 2. Напишите программу,которая принимает на вход три числа и выдаёт максимальное из этих чисел
Console. WriteLine("Введи A:");
int num1 = int. Parse(Console.ReadLine()!);
Console. WriteLine("Введи B:");
int num2 = int. Parse(Console.ReadLine()!);
Console. WriteLine("Введи C:");
int num3 = int. Parse(Console.ReadLine()!);

int max = num1;
if (max < num2)
{
  max = num2;
}
if (max < num3)
{
max = num3;
}

Console.WriteLine( "Максимальное число равно {max}");



// Задача 3. Напишите программу,которая на вход принимает число и выдает, является ли число четным(делится ли оно на два без остатка)
Console. WriteLine("Введи число:");
int number = int. Parse(Console.ReadLine()!);
if(number % 2 ==0 )
{
Console. WriteLine("Число чётное");
}
else
{
  Console. WriteLine("Число нечётное");
}

// Задача 4.Напишите программу,которая на вход принимает число (N),а на выходе выдает все чётные числа от 1 до N

Console. WriteLine("Введи N:");
int N = int. Parse(Console.ReadLine()!);
int i  = 1;
while(i <= N)
{
  if(N % 2 == 0)
  {
  Console.WriteLine($"{i}");
  }
}
!!
Task completed