// Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше.

Console.WriteLine("Введите 1-ое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2-ое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine( num1 + ">" + num2);
}
else
{
    Console.WriteLine( num2 + ">" + num1);
}

if(num1 < num2)
{
    Console.WriteLine( num1 + "<" + num2);
}
else
{
    Console.WriteLine( num2 + "<" + num1);
}
