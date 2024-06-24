public class StringIteration
{
  public void runStringIteration()
  {
    string message = "C# is awesome";

    for (int i = 0; i < message.Length; i++)
    {
      Console.Write(message[i]);
      System.Threading.Thread.Sleep(100);
    }

    Console.WriteLine(message.Contains("C")); //True

    bool contains = false;
    
    for (int i = 0; i < message.Length; i++)
    {
      if (message[i].Equals('C'))
      {
        contains = true;
      }
    }

    Console.WriteLine(contains);
  }
}