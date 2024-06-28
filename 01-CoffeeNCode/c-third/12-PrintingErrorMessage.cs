public class PrintingErrorMessage
{
  public static void RunPrintingErrorMessage()
  {
    try
    {
      Console.Write("Enter a number : ");
      int num = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(num);
    }
    catch (Exception e)
    {
      Console.WriteLine($"Error: {e.Message}");
    }
    Console.WriteLine("Goodbye!");
  }
}