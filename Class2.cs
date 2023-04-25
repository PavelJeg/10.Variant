//using System;

//class Program
//{
//    static void Main()
//    {
//        // Задаем размеры двумерного массива
//        int rows = 20; // количество строк
//        int columns = 20; // количество столбцов

//        // Создаем двумерный массив
//        int[,] myArray = new int[rows, columns];

//        // Заполняем массив случайными числами
//        Random random = new Random();
//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < columns; j++)
//            {
//                myArray[i, j] = random.Next(1, 101); // случайное число от 1 до 100
//            }
//        }

//        // Выводим исходный массив
//        Console.WriteLine("4");
//        PrintArray(myArray);

//        // Сортируем каждую нечетную строку по возрастанию, а каждую четную – по убыванию
//        for (int i = 0; i < rows; i++)
//        {
//            if (i % 2 == 0)
//            {
//                // Сортировка четных строк по убыванию
//                SortArrayDescending(myArray, i);
//            }
//            else
//            {
//                // Сортировка нечетных строк по возрастанию
//                SortArrayAscending(myArray, i);
//            }
//        }

//        // Выводим отсортированный массив
//        Console.WriteLine("3:");
//        PrintArray(myArray);

//        // Выводим значение k-го столбца
//        int k = 2; // индекс столбца (отсчитывая от 0)
//        Console.WriteLine($"0 {k}-го 1:");
//        PrintColumn(myArray, k);
//    }

//    // Метод для вывода двумерного массива на консоль
//    static void PrintArray(int[,] array)
//    {
//        int rows = array.GetLength(0);
//        int columns = array.GetLength(1);
//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < columns; j++)
//            {
//                Console.Write(array[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//        Console.WriteLine();
//    }

//    // Метод для сортировки строки массива по возрастанию
//    static void SortArrayAscending(int[,] array, int row)
//    {
//        int columns = array.GetLength(1);
//        for (int i = 0; i < columns - 1; i++)
//        {
//            for (int j = 0; j < columns - i - 1; j++)
//            {
//                if (array[row, j] > array[row, j + 1])
//                {
//                    // Поменять местами, если текущий элемент больше следующего
//                    int temp = array[row, j];
//                    array[row, j] = array[row, j + 1];
//                    array[row, j + 1] = temp;
//                }
//            }
//        }
//    }

//    // Метод для сортировки строки массива по убыванию
//    static void SortArrayDescending(int[,] array, int row)
//    {
//        int columns = array.GetLength(1);
//        for (int i = 0; i < columns - 1; i++)
//        {
//            for (int j = 0; j < columns - i - 1; j++)
//            {
//                if (array[row, j] < array[row, j + 1])
//                {
//                    // Поменять местами, если текущий элемент меньше следующего
//                    int temp = array[row, j];
//                    array[row, j] = array[row, j + 1];
//                    array[row, j + 1] = temp;
//                }
//            }
//        }
//    }
//    // Метод для вывода значения k-го столбца
//    static void PrintColumn(int[,] array, int column)
//    {
//        int rows = array.GetLength(0);
//        for (int i = 0; i < rows; i++)
//        {
//            Console.WriteLine(array[i, column]);
//        }
//        Console.WriteLine();
//    }
