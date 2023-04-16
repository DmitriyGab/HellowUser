// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int[] array = {1, 2, 3, 4, 5, 5556, 7, 8, 9};


// int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));

// Console.WriteLine("Максимальное значение: " +max);


// ПОИСК ЭЛЕМЕНТА МАССИВА, РАВНЫЙ FIND
int[] array = {1, 2, 3, 4, 5, 5556, 7, 8, 5556, 9};

int n = array.Length;
int index = 0;
int find = 5556;

while (index < n)
{
    if(array[index] == find)
    {
    Console.WriteLine(index);
    break; // прерывает поиск по массиву при выявлении нужного значения
    }
    index++;
}



