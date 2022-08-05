// Напишите программу, которая на вход принимает число (N),а на выходе показывает все четные числа от 1 до (N).

Console.WriteLine("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;

Console.WriteLine("Четные числа от 1 до " + num);

while(i <= num)
{
    if(i % 2 != 1)
    {
        Console.Write(i + ", ");
    }
    i++;
}

