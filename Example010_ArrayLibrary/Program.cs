void FillArray(int[] collection)
{
    int length = collection.Length; // определиние длины массива
    int index = 0;

    while(index < length)
    {
    collection[index] = new Random().Next(1, 10);
    index++;
    }

}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int [10]; // создание нового массива с 10 элементами

FillArray(array); // 
PrintArray(array); // Печать массива
