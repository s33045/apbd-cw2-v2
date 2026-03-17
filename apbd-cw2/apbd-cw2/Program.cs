// See https://aka.ms/new-console-template for more information
Console.WriteLine("My great app");

Console.WriteLine("My application");

double CalculateAverage(int[] values)
{
    return values.Average();
}

int CalculateMax(int[] values)
{
    return values.Max();
}

int CalculateMin(int[] values)
{
    if (values.Length == 0)
        throw new ArgumentException("No values in array were provided");

    return values.Min();
}