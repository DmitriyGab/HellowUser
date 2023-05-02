﻿// string[,] table = new string[2, 5];
// table [0,0] table [0,1] table [0,2] table [0,3] table [0,4]
// table [1,0] table [1,1] table [1,2] table [1,3] table [1,4]

// table [1,2] = "слово";
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"{table[rosw, columns]}");
//     }
// }

// int[,] matrix = new int[3, 4];

// void PrintArray(int[,] matr) // в названии метода в скобках необходимо указывать какой тип данных он будет передавать после завершения. В данном случае - двумерная таблица чисел
// {
//     for (int i = 0; i < matrix.GetLength(0); i++) // GetLength - в данном случае ссылается на нулевой индекс длины массива matrix (т.е. на цифру 3 в строке 14)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) // GetLength - в данном случае ссылается на первый индекс длины массива matrix (т.е. на цифру 4 в строке 14)
//         {
//             Console.Write($"{matrix[i, j]} "); // не указывать WriteLine, чтобы значения не выводились только в столбик
//         }
//     Console.WriteLine(); // Пусткая строка, чтобы сделать переход на новую строку
//     }
// }

// PrintArray(matrix);
// Console.WriteLine(); // Добавление пустой строки, чтобы разделить массив с нулями от массива со случайными числами

// void FillArray (int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1,10);
//         }
//     }
// }

// FillArray(matrix);
// PrintArray(matrix);


// Закрашивание области

// int[,] pic = new int[,] // картинка
// {
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };

// void PrintImage (int[,] image)
// {
//     for (int i=0; i<image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             if (image[i,j] ==0) Console.Write($" ");
//             else Console.Write($"+");
//         }
//         Console.WriteLine();
//     }
// }

// PrintImage(pic);

// void FillImage (int row, int col)
// {
//     if (pic[row, col]==0)
//     {
//         pic[row, col]= 1;
//         FillImage(row-1,col);
//         FillImage(row,col-1);
//         FillImage(row+1,col);
//         FillImage(row,col+1);
//     }
// }


// PrintImage(pic);
// FillImage(13,13);
// PrintImage(pic);



//  Поиск факториала

//int Factorial (int n) // переменная int будет вычислять факториал только до 17. Потом будет выводить ошибку
// поэтому вместо int необходимо поставить double

// double Factorial (int n)
// {
//     // 1!=1 // факториал 1 будет 1
//     // 0!=1 // факториал 0 тоже будет 1
//     if (n == 1) return 1;
//     else return n * Factorial(n-1);
// }

// for (int i = 1; i < 40; i++) // для i значение должно равняться единице. Промучался лишние 15 мин
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }
// Console.WriteLine(Factorial(17)); // если не использовать цикл for для поиска нужного факториала


// Числа фибоначи

double Fibonacci (int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 30; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}