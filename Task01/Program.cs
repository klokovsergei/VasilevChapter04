﻿// Напишите программу, в которой создается одномерный числовой мас­сив и заполняется числами,
// которые при делении на 5 дают в остатке 2 (числа 2, 7, 12, 17 и так далее). Размер массива
// вводится пользователем. Предусмотреть обработку ошибки, связанной с вводом некорректного значения.

int numsLength;

Console.Write("Данная программа выведет последовательность чисел, которые при делении" + 
 "на 5 дают в остатке 2. ");

while (true){
    try
    {
        Console.Write("Какой длины последовательность вывести: ");
        numsLength = Int32.Parse(Console.ReadLine());
        break;
    }
    catch
    {
        Console.WriteLine("Необходимо ввести положительное целое число!");
    }
}

int[] nums = new int[numsLength];

//заполняем массив
for (int i = 0; i < nums.Length; i++) nums[i] = 5 * i + 2;

//Вывожу получившийся массив
foreach(int i in nums) Console.Write("{0,4}", i);