public class WhileLoops
{
  public void runWhileLoops()
  {
    int i = 0;

    while (i < 10)
    {
      Console.WriteLine(i);
      i++;
    }

    Console.Write("Enter the first number: ");
    int numA = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the second number: ");
    int numB = Convert.ToInt32(Console.ReadLine());

    int answer = numA * numB;
    int actualAnswer = 0;

    Console.Write("What is the value of " + numA + " x " + numB + "?");

    while (answer != actualAnswer)
    {
      Console.Write("Enter your answer: ");
      actualAnswer = Convert.ToInt32(Console.ReadLine());

      if (answer != actualAnswer)
      {
        Console.WriteLine("Close but it was wrong!");
      }
    }

    Console.WriteLine("Well done!");

    actualAnswer = 0;

    Console.Write("What is the value of " + numA + " x " + numB + "?");

    do
    {
      Console.Write("Enter your answer: ");
      actualAnswer = Convert.ToInt32(Console.ReadLine());

      if (answer != actualAnswer)
      {
        Console.WriteLine("Close but it was wrong!");
      }

    } while (answer != actualAnswer);

    Console.WriteLine("Well done!");
  }
}
