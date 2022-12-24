Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine("Первое число больше второго и третьего");
}
else if (num2 > num1 && num2 > num3)
{
    Console.WriteLine("Второе число больше первого и третьего");
}
else if (num3 > num1 && num3 > num2)
{
    Console.WriteLine("Третье число больше первого и второго");
}
else if (num1 == num2 && num1 == num3 && num2 == num3)
{
    Console.WriteLine("Все числа равны");
}
