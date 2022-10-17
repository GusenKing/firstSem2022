/*int m = 3, n = 4, k = 5;
var matrix1 = new int[m, n];
var matrix2 = new int[n, k];

var rnd = new Random();
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
        matrix1[i, j] = rnd.Next(-10, 11);
}
for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
        matrix2[i, j] = rnd.Next(-10, 11);
}

if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
    PrintMatrix(matrix1);
    PrintMatrix(matrix2);
    PrintMatrix(ProductOdMatrices(matrix1, matrix2));
}
else
    Console.WriteLine("Нельзя перемножить");*/


/*int k = int.Parse(Console.ReadLine());
var matrixA = new int[2, 2] { { 1, 1 }, { 1, 0 } };
var matrixB = matrixA;
int count = 1;
while (count < k)
{
    matrixA = ProductOdMatrices(matrixA, matrixB);
    count++;
}
PrintMatrix(matrixA);*/



int[,] ProductOdMatrices(int[,] m1, int[,] m2)
{
    var answerMatrix = new int[m1.GetLength(0), m2.GetLength(1)];
    for (int i = 0; i < m1.GetLength(0); i++)
    {
        for (int j = 0; j < m2.GetLength(1); j++)
        {
            int curSum = 0;
            for (int s = 0; s < m1.GetLength(1); s++)
                curSum += m1[i, s] * m2[s, j];
            answerMatrix[i, j] = curSum;
        }
    }
    return answerMatrix;
}

void PrintMatrix(int[,] arr1)
{
    for(int i = 0; i < arr1.GetLength(0); i++)
    {
        for(int j = 0; j < arr1.GetLength(1); j++)
            Console.Write(arr1[i, j].ToString() + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}