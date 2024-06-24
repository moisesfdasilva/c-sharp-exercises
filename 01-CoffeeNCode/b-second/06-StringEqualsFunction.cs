public class StringEqualsFunction
{
  public void runStringEqualsFunction()
  {
    string message = "Hello";
    string compare = "Hello";

    // message == compare
    if (message.Equals(compare))
    {
      Console.WriteLine("Same");
    }
    else
    {
      Console.WriteLine("Different");
    }

    Console.Write("Enter your name: ");
    string name = Console.ReadLine();

    // if (name != "")
    if (message.Equals(compare))
    {
      Console.WriteLine($"Your name is {name}.");
    }
    else
    {
      Console.WriteLine("Invalid name input.");
    }

    char[] chars = new char[] {'H', 'e', 'l', 'l', 'o'};
    object newCompare = new string(chars);

    // message == newCompare  ---> Different because it verify the memory location.
    if (message.Equals(newCompare))
    {
      Console.WriteLine("Same");
    }
    else
    {
      Console.WriteLine("Different");
    }
  }
}