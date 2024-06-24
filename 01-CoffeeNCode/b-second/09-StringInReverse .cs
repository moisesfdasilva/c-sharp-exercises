public class StringInReverse
{
  public void runStringInReverse()
  {
    /*
    1- Ask user to input message
    2- Print in order
    3- Print in reverse
    */
    Console.Write("Enter your message: ");
    string message = Console.ReadLine();

    Console.WriteLine(message);

    string messageReverse = "";
    int i = message.Length - 1;

    while (i >= 0)
    {
      messageReverse = string.Concat(messageReverse, message[i]);
      i--;
    }

    Console.WriteLine(messageReverse);
  }
}