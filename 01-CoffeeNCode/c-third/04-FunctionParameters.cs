public class FunctionParameters
{
  public static void RunFunctionParameters()
  {
    int numA = ReadInt("Enter a first number");
    int numB = ReadInt("Enter a second number");
    int sumAB = SumAB(numA, numB);
    Console.WriteLine(sumAB);
  }

  static int ReadInt(string message)
  {
    Console.WriteLine($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
  }

  static int SumAB(int a, int b)
  {
    return a + b;
  }
}