class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("### Select race mode ###");
    Console.WriteLine("1-Easy | 2-Normal | 3_Hard");
    Console.WriteLine("The game will be: ");
    Game game = null;
    switch (Console.ReadLine())
    {
      case "1": game = new EasyMode(); break;
      case "3": game = new HardMode(); break;
      default : game = new NormalMode(); break;
    }
  }
}
