namespace ProjectEuler;

public class Problem7
{
    public static bool isPrime(int n)
    {
        if (n == 0 || n == 1) return false;
        
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }
    public static void Solve()
    {
        int primeIndex = 1;
        int i = 3;
        while (primeIndex < 10001)
        {
            if (isPrime(i))
                primeIndex++;
            i++;
        }

        Console.WriteLine(i-1); // off by one error :(
        Console.WriteLine(primeIndex);
    }
}