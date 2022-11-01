//Генерация матрицы
int[,] GenerateMatrix(int size, int minValue, int maxValue) 
{
    var matrix = new int[size, size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
        for(int j = 0; j < size; j++)
        {
            matrix[i, j] = rnd.Next(minValue, maxValue);
        }
    return matrix;
}

//Запись матрицы в файл
void WriteMatrixToFile(int[,] matrix, string fileName) 
{
    using(StreamWriter writer = new StreamWriter(fileName))
    {
        var size = matrix.GetLength(0);
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
                writer.Write($"{matrix[i, j]} ");
            writer.WriteLine();
        }
    }
}

//Вывод матрицы на экран
void PrintMatrix(int[,] matrix)
{
    var size = matrix.GetLength(0);
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

//Чтение матрицы из файла
int[,] ReadMatrixFromFile(string fileName, int size)
{
    int[,] matrix;
    using(StreamReader reader = new StreamReader(fileName))
    {
        matrix = new int[size, size];
        for (int i = 0; i < size; i++)
        {
            var row = reader.ReadLine().Split(' ');
            for (int j = 0; j < size; j++)
            {
                matrix[i, j] = int.Parse(row[j]);
            }
        }
    }
    return matrix;
}

//Сгенерировать случайное простое число
int GetRandomPrime(int minValue, int maxValue)
{
    var rnd = new Random();
    while (true)
    {
        bool flag = true;
        var newNumber = rnd.Next(minValue, maxValue);
        for (int i = 2; i * i < newNumber; i++)
        {
            if (newNumber % i == 0)
            {
                flag = false;
                break;
            }
        }
        if (flag)
            return newNumber;
    }
}

//Сгенерировать матрицу из простых чисел ( 2.. 1 000 000)
int[,] GeneratePrimeMatrix(int size)
{
    var matrix = new int[size, size];
    for (int i = 0; i < size; i++)
        for (int j = 0; j < size; j++)
            matrix[i, j] = GetRandomPrime(2, 1000000);
    return matrix;
}

//Поиск индекса минимального элемента
//Возвращает массив координат
int[] FindMinIndex(int[,] matrix)
{
    int minValue = int.MaxValue;
    int[] minIndex = new int[2];
    var size = matrix.GetLength(0);
    for (int i = 0; i < size; i++)
        for (int j = 0; j < size; j++)
        {
            if (minValue > matrix[i, j])
            {
                minValue = matrix[i, j];
                minIndex[0] = i;
                minIndex[1] = j;
            }
        }
    return minIndex;
}

//Поиск индекса максимального элемента
//Возвращает массив координат
int[] FindMaxIndex(int[,] matrix)
{
    int maxValue = int.MinValue;
    int[] maxIndex = new int[2];
    var size = matrix.GetLength(0);
    for (int i = 0; i < size; i++)
        for (int j = 0; j < size; j++)
        {
            if (maxValue < matrix[i, j])
            {
                maxValue = matrix[i, j];
                maxIndex[0] = i;
                maxIndex[1] = j;
            }
        }
    return maxIndex;
}

//Поменять строку с минимальных числом со строкой с максимальным числом  
void SwapMinMaxRows(int[,] matrix)
{
    var iMax = FindMaxIndex(matrix);
    var iMin = FindMinIndex(matrix);
    Console.WriteLine($"{iMax[0]} {iMax[1]}\n{iMin[0]} {iMin[1]}");
    if (iMax[0] == iMin[0])
        return;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        var temp = matrix[iMax[0], i];
        matrix[iMax[0], i] = matrix[iMin[0], i];
        matrix[iMin[0], i] = temp;
    }
}

//Возвращает индекс симметричного столбца, -1 при отсутствии такового
int IndexOfSymmetricalColumn(int[,] matrix)
{
    bool isSymmetrical;
    var n = matrix.GetLength(1);
    for (int j = 0; j < n; j++)
    {
        isSymmetrical = true;
        for (int i = 0; i < n; i++)
        {
            if (matrix[i, j] != matrix[n - i - 1, j])
            {
                isSymmetrical = false;
                break;
            }
        }
        if (isSymmetrical)
            return j;
    }
    return -1;
}

//Найти сумму симметричного столбца
int SumOfSymmetricalColumn(int[,] matrix, int index)
{
    int resultSum = 0;
    var n = matrix.GetLength(1);

    for (int i = 0; i < n; i++)
    {
        if (matrix[i, index] == matrix[n - i - 1, index])
            resultSum += matrix[i, index];
    }
    return resultSum;
}

//Функции и процедуры:
var mtr = GenerateMatrix(10, -100, 101);
WriteMatrixToFile(mtr, "output.txt");
var readedMatrix = ReadMatrixFromFile("input.txt", 5);
PrintMatrix(mtr);
PrintMatrix(readedMatrix);

//Задания 1-го варианта
var primeMatrix = GeneratePrimeMatrix(10);
PrintMatrix(primeMatrix);

SwapMinMaxRows(primeMatrix);
PrintMatrix(primeMatrix);

if (IndexOfSymmetricalColumn(readedMatrix) != -1)
    Console.WriteLine(SumOfSymmetricalColumn(readedMatrix, IndexOfSymmetricalColumn(readedMatrix)));
