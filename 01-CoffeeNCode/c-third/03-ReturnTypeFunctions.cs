public class ReturnTypeFunctions
{
  public static void RunReturnTypeFunctions()
  {
    PrintIndroduction();
    int num = ReadNumberFromConsole();
    Console.WriteLine($"Your namer is {num}.");
  }

  static int ReadNumberFromConsole()
  {
    Console.Write("Enter a number: ");
    return Convert.ToInt32(Console.ReadLine());
  }

  static string OneName()
  {
    return "Moshe";
  }

  static int OneAge()
  {
    return 27;
  }

  static void PrintIndroduction()
  {
    Console.WriteLine($"Hello my name is {OneName()} and my age is {OneAge()}.");
  }
}