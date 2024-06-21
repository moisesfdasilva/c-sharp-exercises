using System.Globalization;

public class NumericFormatting
{
  public void runNumericFormatting()
  {
    double value = 1000D / 12.34D;

    Console.WriteLine(value);
    Console.WriteLine(string.Format("{0:0}", value));
    Console.WriteLine(string.Format("{0:0.0}", value));
    Console.WriteLine(string.Format("{0:0.00}", value));

    Console.WriteLine(string.Format("{0:0.#}", value));

    double money = 10D / 3D; // 3.3333

    Console.WriteLine(money);
    Console.WriteLine(string.Format("£{0:0.0}", value));
    Console.WriteLine(money.ToString("C"));
    Console.WriteLine(money.ToString("C1"));
    Console.WriteLine(money.ToString("C2"));

    Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
    Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
    Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
    Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-AU")));
    Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
  }
}
