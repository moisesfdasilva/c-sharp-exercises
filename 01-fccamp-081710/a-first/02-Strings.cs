public class Strings
{
  public void runStrings()
  {
    string name = "Aba";
    char letter = 'a';

    Console.Write("Your name is: ");
    Console.WriteLine(name);
    Console.WriteLine(letter);

    string textNumberInt = "-23";
    int numberInt = Convert.ToInt32(textNumberInt);
    Console.WriteLine(numberInt);

    string textNumberLong = "-900000000";
    long numberLong = Convert.ToInt64(textNumberLong);
    Console.WriteLine(numberLong);

    string textNumberDouble = "-55.2";
    double numberDouble = Convert.ToDouble(textNumberDouble);
    Console.WriteLine(numberDouble);

    string textNumberFloat = "5.000002";
    float numberFloat = Convert.ToSingle(textNumberFloat);
    Console.WriteLine(numberFloat);

    string textNumberDecimal = "14.99";
    decimal numberDecimal = Convert.ToDecimal(textNumberDecimal);
    Console.WriteLine(numberDecimal);

    // The "." isn't converted, but "," is converted.
  }
}
