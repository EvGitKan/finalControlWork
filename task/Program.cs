// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо
// задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.


//Считаем какое количество элементов(строк) соответствует условию, чтобы задать размерность новому массиву.
int CountElementsByCondition(String[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

//Формируем новый массив из строк <= 3 символов.
String[] СreateNewArray (String[] array, int countElements)
{
    String[] newArraysRow = new String[countElements];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            newArraysRow[j] = array[i];
            j++;
        }
    }
    return newArraysRow;
}

//Вывести новый массив в консоль
void PrintNewArray(String[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}


String[] arraysRow = {"Hello", "2", "world", ":-)"};
int countElementsByCondition = CountElementsByCondition(arraysRow);
String[] newArray = СreateNewArray(arraysRow, countElementsByCondition);
PrintNewArray(newArray);