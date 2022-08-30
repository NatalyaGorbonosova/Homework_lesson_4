//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int SumNumbers(string number)
{
    int n = number.Length;
    int num = Convert.ToInt32(number);
    int sum = 0;
    for(int i = n - 1; i >= 0; i--) sum = sum + (num /Convert.ToInt32(Math.Pow(10, i)))%10;
    return sum;
}
try
{
    Console.WriteLine("Введите целое число");
    string str = Console.ReadLine();
    int answer = SumNumbers(str);
    Console.WriteLine($"Сумма цифр числа равна: {answer}");
    
}
catch
{
    Console.WriteLine("Введите целое число");
}
