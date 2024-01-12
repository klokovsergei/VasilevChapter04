// Напишите программу, в которой создается массив и заполняется слу­чайными числами. Массив
// отображается в консольном окне. В этом массиве необходимо определить элемент с минимальным значением.
// В частности, программа должна вывести значение элемента с минималь­ным значением и индекс этого элемента.
// Если элементов с минималь­ным значением несколько, должны быть выведены индексы всех этих элементов.

Console.Write("Введите размерность создаваемого массива: ");
int numsLength = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[numsLength];

//Создаем объект класса Рандом и заполняем массив
Random random = new Random();
for (int i = 0; i < numsLength; i++)
{
    nums[i] = random.Next(-100, 100);
}

//выводим сгенерированный массив:
Console.Write(string.Join(" | ", nums));

int count = 0;
int minNumber = nums[0];

foreach (int i in nums)
{
    if (minNumber == i) count += 1;
    else if (minNumber > i)
    {
        minNumber = i;
        count = 1;
    }
}
int[] arrMin = new int[count];
int j = 0;
for (int i = 0; i < numsLength; i++)
{
    if (minNumber == nums[i])
    {
        arrMin[j] = i;
        j++;
    }
}

Console.WriteLine($"\nМинимальное значение равно {minNumber}. Встречается значение {count} раз.");
Console.WriteLine("Индексы мин значений в исходном массиве: [ " + string.Join(" | ", arrMin) + " ]");
