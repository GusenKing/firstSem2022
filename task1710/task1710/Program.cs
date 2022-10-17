var rnd = new Random();

var arr = new int[rnd.Next(10, 20)];
int max = int.MinValue, min = int.MaxValue, minIndex = 0, maxIndex = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(0, 50);
    Console.Write(arr[i].ToString() + " ");
    if (arr[i] > max)
    {
        max = arr[i];
        maxIndex = i;
    }
    if (arr[i] < min)
    {
        min = arr[i];
        minIndex = i;
    }
}

int summ = 0;
for (int i = Math.Min(minIndex, maxIndex) + 1; i < Math.Max(maxIndex, minIndex); i++)
    summ += arr[i];

Console.WriteLine();
Console.WriteLine(summ);
