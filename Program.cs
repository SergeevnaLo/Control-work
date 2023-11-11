//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 

// Объявление двух массивов:

string[] array1 = new string[7] { "13", "200", "Hello", "07", "Russia", "Yes", "Good" };
string[] array2 = new string[array1.Length];

// Проверка выполнения условия <=3
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

// Выполнение цикла for и вывод результата 
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

SecondArrayWithIF(array1, array2);
PrintArray(array2);
