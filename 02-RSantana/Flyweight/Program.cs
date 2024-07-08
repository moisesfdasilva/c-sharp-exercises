class Program
{
  static void Main(string[] args)
  {
    Flyweight flyweight = new Flyweight();
    string color = string.Empty;

    Turtle turtle;

    while (true)
    {
      Console.WriteLine("Select some turtle.");
      color = Console.ReadLine();

      turtle = flyweight.GetTurtle(color);
      turtle.Show(color);
      Console.WriteLine("-----------");
    }
  }
}
