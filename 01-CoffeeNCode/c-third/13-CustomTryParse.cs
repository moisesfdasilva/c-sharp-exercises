public class CustomTryParse
{
  public static void RunCustomTryParse()
  {
    /*
    Create a int and try convert any string to an int
    Notice the error, write a try...catch handler around it
    Catch the error and output the error message
    Without changing the current code

    Why is this a bad situation and how can we know if its been converted?

    Create a custom try parse function
    Find the real function an copy return ty/params
    Read the tooltip it gives you, to give you ideas on what to do
    */

    ConvertInput();

    Console.Write("Enter a number: ");
    if (TryParse(Console.ReadLine(), out int result))
    {
      Console.Write("Yey " + result);
    }
    else
    {
      Console.Write("Oh no");
    }
    
  }
  static bool TryParse(string input, out int result)
  {
    result = -1;
    try
    {
      result = Convert.ToInt32(input);
      return true;
    }
    catch (Exception)
    {
      return false;
    }
  }
  static void ConvertInput()
  {
    bool success = false;

    try
    {
      Console.WriteLine("Enter a number: ");
      int num = Convert.ToInt32(Console.ReadLine());
      success = true;
    }
    catch (FormatException e)
    {
      Console.WriteLine(e.Message);
    }
    Console.WriteLine(success ? "Yey" : "Oh no");
  }
}