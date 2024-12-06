namespace Day1;

using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var input = File.ReadLines("numbers.txt").ToList();
        List<double> num1 = new List<double>();
        List<double> num2 = new List<double>();
        List<double> sum = new List<double>();
        foreach (var line in input)
        {
            var num = line.Split("   ").Select(double.Parse).ToList();
            num1.Add(num[0]);
            num2.Add(num[1]);
        }
        num1.Sort();
        num2.Sort();
        for (int i = 0; i < num1.Count; i++)
        {
            double diff = Math.Max(num1[i], num2[i]) - Math.Min(num1[i], num2[i]);
            sum.Add(diff);
        }
        foreach (var item in sum)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine(sum.Sum());
    }
}
