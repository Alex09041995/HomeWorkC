Console.WriteLine("Введите любое число : ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 1;
       
if (result == 1)
{
result += 1;
}
while (result <= number)
{
Console.WriteLine("Данное число является чётным:");
Console.WriteLine(result);
result += 2;
}