// необязательная задача Написать программу сортировки массива от большего к меньшему. 
//Массив задается размерностью N с клавиатуры, далее заполняется случайными целыми числами.
int[] FillArray(int[] arr)
{
    Console.WriteLine("Введите элементы массива: ");
    for(int i=0; i < arr.Length; i++) arr[i] = Convert.ToInt32(Console.ReadLine());
    return arr;
}
void ArrayMaxMin(int[] collection)
{
    for(int index = 0; index < collection.Length - 1; index++)
    {
        int maxPosition = index;
        for(int j = index + 1; j < collection.Length; j++)
        {
            if(collection[j]>collection[maxPosition]) maxPosition = j;
        }
        int temporary = collection[index];
        collection[index] = collection[maxPosition];
        collection[maxPosition] = temporary;
    }
}
try
{
    Console.WriteLine("Введите количество элементов массива:");
    int count = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[count];
    array = FillArray(array);
    foreach (int i in array) Console.Write($"{i}, ");
    Console.WriteLine();
    ArrayMaxMin(array);
    Console.Write("Отсортированный массив: ");
    foreach (int i in array) Console.Write($"{i}, ");
    Console.WriteLine();
}
catch
{
    Console.WriteLine("Введите только целые числа");
}