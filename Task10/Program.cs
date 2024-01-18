// Напишите программу, в которой создается двумерный числовой мас­сив и
// этот массив заполняется "змейкой": сначала первая строка (сле­ва направо),
// затем последний столбец (сверху вниз), последняя строка (справа налево),
// первый столбец (снизу вверх), вторая строка (слева на­право) и так далее.

void ShowArr(int[,] nums)
{
    Console.Write("\n");
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            Console.Write("{0,4}",nums[i,j]);
        }
        Console.Write("\n");
    }
    Console.Write("\n");
}
Console.Clear();
Console.Write("Укажите размерность двумерного целочисленного массива [ X ,   ]: ");
int sizeArrRow = int.Parse(Console.ReadLine()!);
Console.Write("Укажите размерность двумерного целочисленного массива [   , X ]: ");
int sizeArrCol = int.Parse(Console.ReadLine()!);

//создаем пустой массив
int[,] array = new int[sizeArrRow,sizeArrCol];
ShowArr(array);

//заполняем массив змейкой
int number = 0;
bool reverseRow = false;
bool reverseCol = false;
int i = 0, j = 0;
while (sizeArrRow > 0 || sizeArrCol > 0)
{
    for (int k = 0; k < sizeArrCol; k++) //проходим по строке (меняется индекс колонки)
    {
        array[i,j] = number;
        number++;
        if (reverseCol) j--;
        else j++;
    }
    sizeArrRow--;
    if (reverseCol) 
    {
        i--;
        j++;
    }
    else
    {
        i++;
        j--;
    }

    for (int k = 0; k < sizeArrRow; k++) //проходим по столбцу (меняется индекс строки)
    {
        array[i,j] = number;
        number++;
        if (reverseRow) i--;
        else i++;
    }
    reverseRow = !reverseRow;
    if (reverseRow) 
    {
        i--;
        j--;
    }
    else
    {
        i++;
        j++;
    }
    sizeArrCol--;
    reverseCol = !reverseCol;
    s++;
}

ShowArr(array);