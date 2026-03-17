// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

double CalculateAverage(int[] values)
{
    return  values.Average();
}

int CalculateMax(int[] values)
{
    return values.Max();
}

int CalculateMin(int[] values)
{
<<<<<<< Updated upstream
    if  (values.Length == 0)
        throw new ArgumentException("No array in values were provided");
    
=======
    if (values.Length == 0)
        throw new ArgumentException("No array values in were provided");

>>>>>>> Stashed changes
    return values.Min();
}