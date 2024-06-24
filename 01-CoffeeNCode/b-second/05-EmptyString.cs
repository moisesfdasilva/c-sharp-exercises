public class EmptyString
{
  public void runEmptyString()
  {
    Console.WriteLine("Enter your name: ");
    string name = Console.ReadLine();
    
    if (name != string.Empty)
    {
      Console.WriteLine($"Your name is {name}.");
    }
    else
    {
      Console.WriteLine("Your name is empty.");
    }
  }
}