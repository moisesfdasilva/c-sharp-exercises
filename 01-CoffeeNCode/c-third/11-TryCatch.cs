public class TryCatch
{
  public static void RunTryCatch()
  {
    bool looping = true;

    while (looping)
    {
      try
      {
        Console.Write("Enter a number : ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(num);

        looping = false;
      }
      catch (OverflowException)
      {
        Console.WriteLine("Please only a number less than 2 billion!");
      }
      catch (FormatException)
      {
        Console.WriteLine("Please only enter numbers!");
      }
      catch (Exception)
      {
        Console.WriteLine("Something has went wrong!");
      }
    }

    Console.WriteLine("Goodbye!");
  }
}