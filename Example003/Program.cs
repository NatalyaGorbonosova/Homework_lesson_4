// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] FillArray(int[] arr)
{
    for(int i=0; i < arr.Length; i++) arr[i] = Convert.ToInt32(Console.ReadLine());
    return arr;
}
try
{
    Console.WriteLine("Введите элементы массива");
    int[] array = new int[8];
    array = FillArray(array);
    foreach (int i in array) Console.Write($"{i}, ");
    Console.WriteLine();
}
catch
{
    Console.WriteLine("Введите целые числа");
}
