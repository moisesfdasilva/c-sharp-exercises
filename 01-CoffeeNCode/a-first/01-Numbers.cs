public class Numbers
{
  public void runNumbers()
  {
    Console.WriteLine("Someone is letting us dream!");

    int ageA = 23;
    Console.WriteLine(ageA);
    int ageB = -23;
    Console.WriteLine(ageB);
    Console.WriteLine("int, min and max:");
    Console.WriteLine(int.MaxValue);
    Console.WriteLine(int.MinValue);

    long bigNumberA = 900000000L;
    Console.WriteLine(bigNumberA);
    long bigNumberB = -900000000L;
    Console.WriteLine(bigNumberB);
    Console.WriteLine("long, min and max:");
    Console.WriteLine(long.MaxValue);
    Console.WriteLine(long.MinValue);

    double numberDoubleA = 55.2D;
    Console.WriteLine(numberDoubleA);
    double numberDoubleB = -55.2D;
    Console.WriteLine(numberDoubleB);
    Console.WriteLine("double, min and max:");
    Console.WriteLine(double.MaxValue);
    Console.WriteLine(double.MinValue);

    float numberFloatA = 5.000001F;
    Console.WriteLine(numberFloatA);
    float numberFloatB = -5.000001F;
    Console.WriteLine(numberFloatB);
    Console.WriteLine("float, min and max:");
    Console.WriteLine(float.MaxValue);
    Console.WriteLine(float.MinValue);

    decimal moneyA = 14.99M;
    Console.WriteLine(moneyA);
    decimal moneyB = -14.99M;
    Console.WriteLine(moneyB);
    Console.WriteLine("decimal, min and max:");
    Console.WriteLine(decimal.MaxValue);
    Console.WriteLine(decimal.MinValue);
  }
}
