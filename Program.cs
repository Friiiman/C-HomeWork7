// ------------- ЗАДАЧИ -------------
// ----------------------------------

void Task1(){

    // Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

    Console.Write("Задайте количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Задайте количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[rows, columns];
    FillArrayDouble(array);
    PrintArrayDouble(array);
}

void Task2(){

    // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
    // и возвращает значение этого элемента или же указание, что такого элемента нет.

    Console.Write("Задайте количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Задайте количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);

    Console.Write("Введите номер строки в которой находится нужный элемент: ");
    int numberRow = Convert.ToInt32(Console.ReadLine());
    if(numberRow <= 0){
        Console.WriteLine("Введено неверное значение");
        Console.Write("Введите номер строки ещё раз: ");
        numberRow = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("Введите номер столбца в которой находится нужный элемент: ");
    int numberColumn = Convert.ToInt32(Console.ReadLine());
    if(numberColumn <= 0){
        Console.WriteLine("Введено неверное значение");
        Console.Write("Введите номер столбца ещё раз: ");
        numberColumn = Convert.ToInt32(Console.ReadLine());
    }

    if(numberRow > rows || numberColumn > columns){
        Console.WriteLine("Такого элемента нет");
    }
    else{
        Console.Write(array[numberRow - 1, numberColumn - 1]);
        Console.Write($" - элемент находящийся на {numberRow} строке в {numberColumn} столбце");
    }
}

void Task3(){

    // Задайте двумерный массив из целых чисел. 
    // Найдите среднее арифметическое элементов в каждом столбце.

    Console.Write("Задайте количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Задайте количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    FillArray(array, 1, 10);
    PrintArray(array);

    double average = 0;
    double sum = 0;
    Console.WriteLine();
    Console.WriteLine("Среднее арифметическое элементов в каждом столбце");
    for(int i = 0; i < columns; i++){
        for(int j = 0; j < rows; j++){
            sum += array[j, i];
        }
        average = Math.Round(sum / rows, 2);
        sum = 0;
        Console.Write(average + "\t");
    }
}

// ------------- МЕТОДЫ -------------
// ----------------------------------

void FillArray(int [,] array, int startNumber = 0, int finishNumber = 100){
    finishNumber++;
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < columns; j++){
            array[i, j] = random.Next(startNumber, finishNumber);
        }
    }
}

void PrintArray(int [,] array){
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < columns; j++){
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void FillArrayDouble(double [,] array, int startNumber = 0, int finishNumber = 100){
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < columns; j++){
            array[i, j] = Math.Round(random.Next(startNumber, finishNumber) + random.NextDouble(), 1);
        }
    }
}

void PrintArrayDouble(double [,] array){
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < columns; j++){
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

// ------------- ВЫВОД РЕШЕНИЯ ЗАДАЧ -------------
// -----------------------------------------------

Task1();
// Task2();
// Task3();
