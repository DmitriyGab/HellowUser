void FillArray(int[] collection)
{
    int length = collection.Length; // определиние длины массива
    int index = 0;

    while(index < length)
    {
    collection[index] = new Random().Next(1, 10); // создание нового массива от 1 до 9
    index++;
    }

}

void PrintArray(int[] col) // вывод элементов массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) // поиск нужного значения в массиве
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // Если в поиске введем число, которого не будет в созданном массиве, то значение -1 будет подсказывать, что это именно так
    
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; // останавливает цикл при нахождении нужного значения
        }
        index++;
    }
    return position;
}

int[] array = new int [10]; // создание нового массива с 10 элементами

FillArray(array); // 
PrintArray(array); // Печать массива
Console.WriteLine(); // Пустая строка, чтобы отделить позицию искомого значения от значений массива PrintArray

int pos = IndexOf(array, 2); // поиск нужного значения в массиве
Console.WriteLine(pos); // вывод позиции нужного значения в массиве