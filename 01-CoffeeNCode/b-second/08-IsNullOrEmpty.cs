public class IsNullOrEmpty
{
  public void runIsNullOrEmpty()
  {
    Console.Write("Enter your name: ");
    string name = Console.ReadLine();

    Console.WriteLine($"Your name is {name}.");
    
    // if (name != "")
    // {
    //   Console.WriteLine("0");
    // }

    // if (name.Equals(""))
    // {
    //   Console.WriteLine("1");
    // }
    
    if (!string.IsNullOrEmpty(name))
    {
      Console.WriteLine("2");
    }
  }
}