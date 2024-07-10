public class Receiver
{
  public void FirstSolicitation(string a)
  {
    Console.WriteLine("Command Received: " + a);
  }

  public void SecondSolicitation(string b)
  {
    Console.WriteLine("Other Command Received" + b);
  }
}