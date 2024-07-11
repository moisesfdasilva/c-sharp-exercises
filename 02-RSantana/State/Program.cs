class Program
{
  static void Main(string[] args)
  {
    Context context = new Context(new CharacterA());

    context.Replace();
    context.Replace();
    context.Replace();
    context.Replace();
    context.Replace();

    Console.ReadKey();
  }
}
