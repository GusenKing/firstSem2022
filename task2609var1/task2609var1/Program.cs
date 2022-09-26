double x = double.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());

string answer = "NO";
if (y >= 0 && y <= 1 && x <= 1 && x >= 0)
{
    answer = "YES";
}
else if (x >= -1 && x <= 0 && y <= x + 1 && y >= 0)
{
    answer = "YES";
}
else if (x >= -1 && x <= 0 && y >= -1 && y <= 0
    && x * x + y * y <= 1)
{
    answer = "YES";
}
Console.WriteLine(answer);
