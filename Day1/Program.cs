namespace Day1;

using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var input = File.ReadLines("numbers.txt").ToList();
        List<double> left = new List<double>();
        List<double> right = new List<double>();
        List<double> sum = new List<double>();
        int similar = 0;
        foreach (var line in input)
        {
            var num = line.Split("   ").Select(double.Parse).ToList();
            left.Add(num[0]);
            right.Add(num[1]);
        }
        left.Sort();
        right.Sort();
        for (int i = 0; i < left.Count; i++)
        {
            double diff = Math.Max(left[i], right[i]) - Math.Min(left[i], right[i]);
            sum.Add(diff);
        } 
        foreach (int number in left)
        {
            int count = right.Count(x => x == number);
            similar += number * count;
        }
        Console.WriteLine(sum.Sum());
        Console.WriteLine(similar);
    }
}
