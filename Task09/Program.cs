// Напишите программу, в которой создается и инициализируется дву­мерный числовой массив.
// Затем из этого массива удаляется строка и столбец (создается новый массив,
// в котором по сравнению с исход­ным удалена одна строка и один столбец).
// Индекс удаляемой строки и индекс удаляемого столбца определяется с помощью генератора слу­чайных чисел.

void ShowArr(int[,] nums)
{
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            Console.Write(nums[i,j] + " ");
        }
        Console.Write("]\n");
    }
}

Console.Write("Введите размерность двумерного массива [ X ,   ]: ");
int firstSize = int.Parse(Console.ReadLine());
Console.Write("Введите размерность двумерного массива [   , X ]: ");
int secondSize = int.Parse(Console.ReadLine());

//создаем двумерный массив
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

//определим какая строка и столбец будут удалены
int delRow = random.Next(0, array.GetLength(0));
int delCol = random.Next(0, array.GetLength(1));

Console.WriteLine("Будут удалены строка - {0} и колонка - {1}.", delRow, delCol);

//удаление строки и столбца выбранных случайным образом

//новый массив -1 строка - столбец
int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

for (int i = 0, k = 0; i < array.GetLength(0); i++)
{
    if (i == delRow - 1) continue;

    for (int j = 0, s = 0; j < array.GetLength(1); j++)
    {
        if (j == delCol - 1) continue;
        newArray[k,s] = array[i,j];
        s++;
    }
    k++;
}

ShowArr(newArray);