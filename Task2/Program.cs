Console.WriteLine("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
 
if(num1 > num2)
{
    Console.WriteLine("Первое число больше второго");
}
else if (num1 < num2)
{
    Console.WriteLine("Второе число больше первого");
}
else if (num1 == num2)
{
    Console.WriteLine("Числа равны друг другу");
}
