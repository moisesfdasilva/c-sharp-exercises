class Program
{
  static void Main(string[] args)
  {
    Backpack backpack = new Backpack(new Rope(), new Binoculars(),
      new BowAndArrow());
    backpack.Interpreter(new Context());
  }
}
