namespace ProjectEuler;

public class Problem8
{
    public static void Solve()
    {
        var lines = File.ReadAllLines("C:\\Users\\aman\\RiderProjects\\ProjectEuler\\ProjectEuler\\data\\Problem8.txt");
        var data = string.Concat(lines);

        long max = long.MinValue;
        string maxString = "";
        const int numOfChar = 13;
        for (int i = 0; i < data.Length-numOfChar; i++)
        {
            var Num = data[i..(i + numOfChar)];
            long mul = 1;
            foreach (var c in Num)
            {
                mul *= long.Parse(c.ToString());
            }

            if (mul > max)
            {
                max = mul;
                maxString = Num;
            }
        }

        Console.WriteLine(max);
        Console.WriteLine(maxString);
    }
}