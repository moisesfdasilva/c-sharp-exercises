public class IfStatements
{
  public void runIfStatements()
  {
    Console.Write("What is your name? ");
    string name = Console.ReadLine();

    Console.Write("What is your age? ");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Your name is " + name + " and your age is " + age + ".");

    // == ----> WORKING IN STRINGS!
    // ==, >, >=, <, <=, !=  ----> WORKING IN NUMBER!
    if (age < 0 || age > 150)
    {
      Console.WriteLine("Invalid age!");
    }
    else
    {
      if (age >= 18 && age <= 25)
      {
        Console.WriteLine("You are between 18 and 25.");
      }
      else if (age >= 26)
      {
        Console.WriteLine("You are 26 or older.");
      }
    }

    Console.WriteLine("Another Question:");
    Console.Write("Enter the first number: ");
    int numA = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the second number: ");
    int numB = Convert.ToInt32(Console.ReadLine());

    int answer = numA * numB;

    Console.Write("Value of " + numA + " x " + numB + ": ");
    int actualAnswer = Convert.ToInt32(Console.ReadLine());

    if (answer == actualAnswer)
    {
      Console.WriteLine("Well done!");
    }
    else
    {
      Console.WriteLine("Close but it was wrong!");
    }
  }
}
