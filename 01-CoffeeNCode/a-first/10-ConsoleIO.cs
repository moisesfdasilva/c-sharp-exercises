public class ConsoleIO
{
  public void runConsoleIO()
  {
    Console.WriteLine("I think, therefore I am.");

    Console.Write("What is your age? ");
    string ageInput = Console.ReadLine();
    int age = Convert.ToInt32(ageInput);

    Console.Write("What are you thinking? ");
    string thought = Console.ReadLine();

    Console.WriteLine("Your age is " + age + " and you have thought in " + thought + ".");
  }
}
