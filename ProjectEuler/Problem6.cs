namespace ProjectEuler;

public class Problem6
{
    public static void Solve()
    {
        const long n = 100;
        long squareOfSum = (long) Math.Pow(n / 2 * (n + 1), 2);
        long sumOfSquares = (n * (n+1) * (2*n +1))/6;
        Console.WriteLine(squareOfSum - sumOfSquares);
    }
}