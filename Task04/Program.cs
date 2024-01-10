// Напишите программу, в которой создается символьный массив из 10 элементов. Массив заполнить
// большими (прописными) буква­ми английского алфавита. Буквы берутся подряд, но только согласные
// (то есть гласные буквы 'А', 'Е' и 'I' при присваивании значений эле­ментам массива нужно пропустить).
// Отобразите содержимое созданного массива в консольном окне.

int numsLength = 10;
char[] array = new char[numsLength];

array[0] = 'B';
//заполняем массив с индекса 1
for (int i = 1; i < array.Length; i++)
{
    array[i] = (char)(array[i - 1] + 1);
    if (array[i] == 'A' || array[i] == 'E' || array[i] == 'I' || array[i] == 'O' || array[i] == 'U' ||
        array[i] == 'Y') array[i] = (char)(array[i - 1] + 2);
}

//отображение массива в прямом порядке
string arrayReverce = "";
foreach (char i in array) 
{
    Console.Write("{0}\t", i);
    arrayReverce = i + "\t" + arrayReverce;
}

//отобразить массив в обратном порядке
Console.Write($"\n{arrayReverce}");
