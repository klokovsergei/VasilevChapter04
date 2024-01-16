// Напишите программу, в которой создается символьный массив, а за­ тем
// порядок элементов в массиве меняется на обратный.

void ShowArray(char[] array)
{
    Console.WriteLine($"\nМассив: [ {string.Join(", ", array)} ]");
}

Console.Write("Укажите размер символьного массива: ");
int sizeArray = Int32.Parse(Console.ReadLine());

char[] symbs = new char[sizeArray];

//наполнение символами
Random rnd = new Random();
for (int i = 0; i < symbs.Length; i++)
{
    symbs[i] = (char)rnd.Next((int)'a',(int)'z');
}

ShowArray(symbs);

//переворачиваю массив
char charForRevers;
for (int i = 0; i < symbs.Length / 2; i++)
{
    charForRevers = symbs[i];
    symbs[i] = symbs[symbs.Length - 1 - i];
    symbs[symbs.Length - 1 - i] = charForRevers;
}

Console.Write("Произвел реверс!");
ShowArray(symbs);
