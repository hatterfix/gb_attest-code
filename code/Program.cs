// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


// Функция RecreateArray сначала считает количество строк массива , длина которых меньше, либо равна 3 символам.


    static string[] RecreateArray(string[] inputArray)
    {
        // Считаем элементы массива - строки, длина которых <= 3
        int count = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                count++;
            }
        }

        // Создаём новый массив, размерности = count
        string[] outputArray = new string[count];

        // Заполняем новый массив строками, длина которых <= 3
        int index = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                outputArray[index] = inputArray[i];
                index++;
            }
        }

        return outputArray;
    }

// Функция для вывода массива
void arrayPrint(string[] array)
{
     System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}
    //-------------------------------------------------------------------

    Console.WriteLine("Введите элементы массива через запятую:");
    string? input = Console.ReadLine();
    string[] array = input.Split(',');
    string[] result = RecreateArray(array);

    Console.WriteLine($"Результат:");
    arrayPrint(RecreateArray(array));

