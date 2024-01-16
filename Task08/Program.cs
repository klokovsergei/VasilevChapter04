// Напишите программу, в которой создается двумерный целочислен­ный массив.
// Он заполняется случайными числами. Затем в этом массиве строки и столбцы меняются местами:
// первая строка становится первым столбцом, вторая строка становится вторым столбцом и так далее.
// На­пример, если исходный массив состоял из 3 строк и 5 столбцов, то в ито­ге получаем массив из 5 строк и 3 столбцов.

void ShowArr(int[,] nums) //показать двумерный массив
{
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            Console.Write(nums[i, j] + " ");
        }
        Console.Write("]\n");
    }

}

Console.Write("Введите размерность двумерного массива: [ X ,   ]: ");
int firstSize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность двумерного массива: [   , X ]: ");
int secondSize = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[firstSize, secondSize];

Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = random.Next(10,100);
    }
}

ShowArr(array);

Console.WriteLine("Транспонируем двумерный массив!");
int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        newArray[j,i] = array[i,j];
    }
}

ShowArr(newArray);