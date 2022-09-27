/*double x = double.Parse(Console.ReadLine());
int k = int.Parse(Console.ReadLine());

double result = 0;
for (int i = 0; i < k; i++)
{
    double tempRes = Math.Sin(x);
    for (int j = 1; j <= i; j++)
        tempRes = Math.Sin(tempRes);

    result += tempRes;
}

Console.WriteLine(result);*/


/*double x = double.Parse(Console.ReadLine());
double eps = double.Parse(Console.ReadLine());
double tempRes = x;
long k = 1;

while (Math.Sin(tempRes) >= eps)
{
    tempRes = Math.Sin(tempRes);
    k++;
}

Console.WriteLine(tempRes);
Console.WriteLine(k);*/


/*double x = double.Parse(Console.ReadLine());
double eps = double.Parse(Console.ReadLine());
double elem = 1;
double summ = 1;
long k = 1;

while (elem >= eps)
{
    elem *= x;
    elem /= k;
    summ += elem;
    k++;
}
Console.WriteLine(summ);
Console.WriteLine(Math.Pow(Math.E, x));*/


/*double x = double.Parse(Console.ReadLine());
double eps = double.Parse(Console.ReadLine());
double elem = 1;
double summ = 1;
int sign = -1;
long k = 2;

while (elem >= eps)
{
    elem *= x * x;
    elem /= (k * (k - 1));
    summ += elem * sign;
    sign *= -1;
    k += 2;
}

Console.WriteLine(Math.Cos(x));
Console.WriteLine(summ);*/


/*int k = int.Parse(Console.ReadLine());
int i = 1;
string sequence = "";
while (true)
{
    sequence += i.ToString();
    if (sequence.Length > k)
    {
        Console.WriteLine(sequence[k - 1]);
        break;
    }
    i++;
}*/


/*for (int i = 100; i < 1000; i++)
{
    if ((i % 10 != i / 100) && (i % 10 != i / 10 % 10) && (i / 100 != i / 10 % 10))
        Console.WriteLine(i);
}*/


