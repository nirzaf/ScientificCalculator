// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public class ScientificCalculator : Calculator
{
    public double Power(double x, double y)
    {
        return Math.Pow(x, y);
    }

    public double SquareRoot(double x)
    {
        return Math.Sqrt(x);
    }

    public double Logarithm(double x)
    {
        return Math.Log(x);
    }

    public double Sine(double x)
    {
        return Math.Sin(x);
    }

    public double Cosine(double x)
    {
        return Math.Cos(x);
    }

    public double Tangent(double x)
    {
        return Math.Tan(x);
    }

    public double Cotangent(double x)
    {
        return 1 / Math.Tan(x);
    }

    public double Secant(double x)
    {
        return 1 / Math.Cos(x);
    }

    public double Cosecant(double x)
    {
        return 1 / Math.Sin(x);
    }

    public double ArcSine(double x)
    {
        return Math.Asin(x);
    }

    public double ArcCosine(double x)
    {
        return Math.Acos(x);
    }

    public double ArcTangent(double x)
    {
        return Math.Atan(x);
    }

    public double ArcCotangent(double x)
    {
        return Math.PI / 2 - Math.Atan(x);
    }

    public double ArcSecant(double x)
    {
        return Math.Acos(1 / x);
    }

    public double ArcCosecant(double x)
    {
        return Math.Asin(1 / x);
    }

    public double HyperbolicSine(double x)
    {
        return (Math.Exp(x) - Math.Exp(-x)) / 2;
    }

    public double HyperbolicCosine(double x)
    {
        return (Math.Exp(x) + Math.Exp(-x)) / 2;
    }

    public double HyperbolicTangent(double x)
    {
        return (Math.Exp(x) - Math.Exp(-x)) / (Math.Exp(x) + Math.Exp(-x));
    }

    public double HyperbolicCotangent(double x)
    {
        return (Math.Exp(x) + Math.Exp(-x)) / (Math.Exp(x) - Math.Exp(-x));
    }

    public double HyperbolicSecant(double x)
    {
        return 2 / (Math.Exp(x) + Math.Exp(-x));
    }

    public double HyperbolicCosecant(double x)
    {
        return 2 / (Math.Exp(x) - Math.Exp(-x));
    }

    public double InverseHyperbolicSine(double x)
    {
        return Math.Log(x + Math.Sqrt(x * x + 1));
    }

    public double InverseHyperbolicCosine(double x)
    {
        return Math.Log(x + Math.Sqrt(x * x - 1));
    }

    public double InverseHyperbolicTangent(double x)
    {
        return Math.Log((1 + x) / (1 - x)) / 2;
    }

    public double InverseHyperbolicCotangent(double x)
    {
        return Math.Log((x + 1) / (x - 1)) / 2;
    }

    public double InverseHyperbolicSecant(double x)
    {
        return Math.Log((Math.Sqrt(x * x - 1) + 1) / x);
    }

    public double InverseHyperbolicCosecant(double x)
    {
        return Math.Log((Math.Sign(x) * Math.Sqrt(x * x + 1) + 1) / x);
    }

    public double LogarithmBase10(double x)
    {
        return Math.Log10(x);
    }

    public double LogarithmBase2(double x)
    {
        return Math.Log2(x);
    }

    public double LogarithmBaseN(double x, double n)
    {
        return Math.Log(x, n);
    }

    public double Factorial(double x)
    {
        double result = 1;
        for (int i = 1; i <= x; i++)
        {
            result *= i;
        }
        return result;
    }

    public double AbsoluteValue(double x)
    {
        return Math.Abs(x);
    }

    public double Ceiling(double x)
    {
        return Math.Ceiling(x);
    }

    public double Floor(double x)
    {
        return Math.Floor(x);
    }

    public double Round(double x)
    {
        return Math.Round(x);
    }

    public double Truncate(double x)
    {
        return Math.Truncate(x);
    }

    public double Remainder(double x, double y)
    {
        return x % y;
    }

    public double Modulus(double x, double y)
    {
        return x - y * Math.Floor(x / y);
    }

    public double Pi()
    {
        return Math.PI;
    }

    public double E()
    {
        return Math.E;
    }

    public double ToRadians(double x)
    {
        return x * Math.PI / 180;
    }
    
}

public class Calculator
{
    public double Add(double x, double y)
    {
        return x + y;
    }

    public double Subtract(double x, double y)
    {
        return x - y;
    }

    public double Multiply(double x, double y)
    {
        return x * y;
    }

    public double Divide(double x, double y)
    {
        return x / y;
    }
}