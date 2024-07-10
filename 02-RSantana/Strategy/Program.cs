using Strategy;

class Program
{
  static void Main(string[] args)
  {
    Help parrot = new Help(new Parrot());
    Console.WriteLine(parrot.ToHelp());

    Help frog = new Help(new Frog());
    Console.WriteLine(frog.ToHelp());

    Console.ReadKey();
  }
}