// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int DegreeAandB(int number1, int number2)
{
    int deg = 1;
    for(int i=1; i<=number2; i++)
    {
        deg = deg * number1;
    }
    return deg;
}
try
{
    Console.WriteLine("Введите два целых числа А и В");
    int A = Convert.ToInt32(Console.ReadLine());
    int B = Convert.ToInt32(Console.ReadLine());
    int result = DegreeAandB(A, B);
    Console.WriteLine($"А в степени В равно {result}");
}
catch
{
    Console.WriteLine("Введите только целые числа");
}