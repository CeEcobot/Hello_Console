Console.WriteLine("Введите первое целое число");
int numa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int numb = Convert.ToInt32(Console.ReadLine());
int square = numb * numb;
if (square == numa)
{
    Console.WriteLine("Первое число является квадратом второго числа");
}
else
Console.WriteLine("Первое число не является квадратом второго числа");
