public class OptionalParameters
{
  public static void RunOptionalParameters()
  {
    int numA = ReadInt("Enter a first number");
    int sumAB = SumAB(numA);
    Console.WriteLine(sumAB);
  }

  static int ReadInt(string message)
  {
    Console.WriteLine($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
  }

  // optional:
  // 1) int b = 50;
  // 2) int b = default; // default = 0
  // 3) [Optional] int b
  static int SumAB(int a, int b = default)
  {
    return a + b;
  }
}