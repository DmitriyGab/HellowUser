// Группа методов № 1, которые ничего не возвращают и ничего не принимают

void Method1()
{
    Console.WriteLine("Автор Дмитрий Гавриленко");
}
Method1(); // Вызов метода
//Method1; // Ошибочный вывод метода без скобок


// Группа методов № 2, которые ничего не возвращают, но могут принимать какие-то аргументы

void Method2(string msg)
{
        Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения"); // Вывод текста метода

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текст", count: 4); // Вывод текста. После кавычек и запятой указывается сколько раз будет повторятся данный текст
Method21(count: 4, msg: "новый текст"); // Порядок указания переменных не влияет на вывод текста. Главное не забывать выставлять запятые между ними.

// Группа методов № 3, которые что-то возвращают, но ничего не принимают

int Method3 ()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);


// Группа методов № 4, которые что-то принмают и что-то возвращают

string Method4 (int count, string text)
{
    int i = 0;
    string result= String.Empty; // String.Empty - пустая строка

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);

// ЦИКЛ FOR

string Method5 (int count, string text)
{
    string result= String.Empty;

    for (int i=0; i<count; i++)   
    {
        result = result + text;
    }
    return result;
}
string res1 = Method5(10, "Method5");
Console.WriteLine(res1);

// Цикл в цикле

for (int i=2; i<10; i++)
{
    for (int j=2; j<10; j++)
    {
        Console.WriteLine($"{i}*{j}={i*j}");
    }
    Console.WriteLine(); // Пустая строка, чтобы отделить одну группу числе от другой
}


// ==========Работа с текстом
// Дан текст. В тексте надовсе пробелы заменить черточками,
// маленькие буквы "к" заменить большими буквами "К", 
// а большие буквы "С" заменить маленькими буквами "с".

// Ясна ли задача?

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
                + "ежели бы вас послали вместо нашего милого Винценгероде, "
                + "вы бы взяли приступом согласие прусского короля."
                + "Вы так красноречивы. Вы дадите мне чаю? Спасибо, Сэр";

string Replace(string text, char oldValue, char newValue) // первая char - старый текст или символ. Вторая char - новый символ или текст, на которой надо заменить
{
    string result = String.Empty;

    int length = text.Length;
    for (int i=0; i<length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
// string newText = Replace(text, " ", "/"); // ошибка, так как стоят кавычки, а должны стоять опострафы
string newText = Replace(text, ' ', '/');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);

// Упорядочивание данных массива (от масимального к минимальному)

int[] arr = {1, 2, 5, 8, 5, 3, 9, 2, 4};

void PrintArray(int[] array) // Вывод массива
{
    int count = array.Length;

    for (int i=0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);

void SelectionSort (int[] array)
{
    for (int i=0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j=i+1; j<array.Length; j++)
        {
            if (array[j] < array[minPosition])
            minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

SelectionSort (arr);
PrintArray (arr);