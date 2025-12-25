namespace ProjectEuler;

public static class Problem5
{
    public static void Solve()
    {
        int i = 1;
        while (true)
        {
            bool isDivisible = true;
            for (int j = 1; j <= 20; j++)
            {
                if(i % j != 0)
                    isDivisible = false;
            }

            if (isDivisible)
            {
                Console.WriteLine(i);
                break;
            }
            i++;
        }
    }
}