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
        foreach (var line in input)
        {
            var num = line.Split("   ").Select(double.Parse).ToList();
            left.Add(num[0]);
        }
        for (int i = 0; i < num1.Count; i++)
        left.Sort();
        right.Sort();
        {
            double diff = Math.Max(left[i], right[i]) - Math.Min(left[i], right[i]);
            sum.Add(diff);
        }
        foreach (var item in sum)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine(sum.Sum());
    }
}
