namespace ProjectEuler;

public class Problem9
{
    public static void Solve()
    {
        for (int i = 0; i <= 1000; i++)
        {
            for (int j = i+1; j <= 1000; j++)
            {
                for (int k = j+1; k <= 1000; k++)
                {
                    if (i + j + k == 1000)
                    {
                        if (i * i + j * j == k * k)
                        {
                            Console.WriteLine(i.ToString() + " " + j.ToString() + " " + k.ToString());
                            Console.WriteLine("Final answer: " + (i*j*k).ToString());
                        }
                    }

                    if (i + j + k > 1000)
                        break;
                }
            }
        }
    }
}