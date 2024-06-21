public class VarKeyword
{
  public void runVarKeyword()
  {
    // var intNum; -----> DON'T WORKING
    var intNum = 23;
    Console.WriteLine(intNum);

    var intLong = 90000000L;
    Console.WriteLine(intLong);

    var intDouble = 55.2D;
    Console.WriteLine(intDouble);

    var intFloat = 5.000001F;
    Console.WriteLine(intFloat);

    var intDecimal = 14.99M;
    Console.WriteLine(intDecimal);

    var name = "Aba";
    Console.WriteLine(name);

    var letter = 'a';
    Console.WriteLine(letter);
  }
}
