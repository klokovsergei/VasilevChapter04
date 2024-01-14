// Напишите программу, в которой создается целочисленный массив, заполняется случайными числами и
// после этого значения элементов в массиве сортируются в порядке убывания значений.

Console.WriteLine("Ввыедите размерность массива случайных числен: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arrayLength];

Random rnd = new Random();
for (int i = 0; i < arrayLength; i++)
{
    array[i] = rnd.Next(-100, 100);
}

Console.WriteLine("Так выглядит массив до сортировки:");
Console.WriteLine("[ " + string.Join(", ", array) + " ]");

//сортировка массива по возрастанию:
int numberChange;
for (int i = 0; i < array.Length; i++)
{    
    for (int j = 0; j < array.Length - i - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            numberChange = array[j];
            array[j] = array[j + 1];
            array[j + 1] = numberChange;
        }
    }
}   

Console.WriteLine("Так выглядит массив после сортировки:");
Console.WriteLine("[ " + string.Join(", ", array) + " ]");
