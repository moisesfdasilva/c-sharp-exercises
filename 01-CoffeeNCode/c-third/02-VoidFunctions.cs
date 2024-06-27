public class VoidFunctions
{
  public static void RunVoidFunctions()
  {
    WelcomeMessage();
    CreateAndPrintArray();
  }
  static void WelcomeMessage()
  {
    Console.WriteLine("Welcome to my program!");
  }
  static void CreateAndPrintArray()
  {
    int[] numbers = new int[5] { 0, 1, 2, 3, 4 };

    foreach (int item in numbers)
    {
      Console.Write($"{item} ");
    }
  }
}