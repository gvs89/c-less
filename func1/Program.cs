double CalculateFormula(int a, int b, int c, int d)
{
    double num = a * b;
    int den = c + d;
    double result = num / den;
    return result;

}

double result = CalculateFormula(3, 2, 3, 4);
Console.WriteLine(result);