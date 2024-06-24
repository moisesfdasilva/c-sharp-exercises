public class ForLoops
{
  public void runForLoops()
  {
    for (int i = 0; i < 5; i ++)
    {
      Console.WriteLine("Kkkkkkkkkkkkk!");
    }

    for (int i = 0; i < 10; i += 5)
    {
      Console.WriteLine(i);
    }

    Console.Write("How many times do tou want to say hi? ");
    int loopCounter = Convert.ToInt32(Console.ReadLine());

    if (loopCounter <= 0)
    {
      Console.WriteLine("Sorry, please enter a value above 0.");
    }
    else
    {
      for (int i = 0; i < loopCounter; i ++)
      {
        Console.WriteLine("Hi");
      }
    }
  }
}
