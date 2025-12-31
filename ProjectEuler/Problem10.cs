namespace ProjectEuler;

public class Problem10
{
    public static void Solve()
    {
        const int maxNum = 2_000_000;
        // const int maxNum = 10;
        Dictionary<int, bool> numbers = new Dictionary<int, bool>();
        for(int i = 2; i < maxNum; i++)
            numbers.Add(i, false);
        int p = 2;
        while (true)
        {
            int i = 2;
            int tmp = p;
            while (tmp*i < maxNum)
            {
                numbers[tmp * i] = true;
                i++;
            }

            i = p+1;
            while (numbers.ContainsKey(i) && numbers[i])
            {
                i++;
            }

            if (i == maxNum+1)
                break;
            p = i;
        }

        long sum = 0;
        for(int i = 2; numbers.ContainsKey(i); i++)
        {
            if (!numbers[i])
            {
                sum += i;
            }
        }

        Console.WriteLine(sum);
    }
}