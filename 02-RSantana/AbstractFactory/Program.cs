class Program
{
  static void Main(string[] args)
  {
    IFactoryBase factory;
    Console.Write("Choose your character: 1-Protoss | 2-Zergs | 3-Terrans: ");

    switch(Console.ReadLine())
    {
      case "1":
        factory = new FactoryBaseProtoss();
        break;
      case "2":
        factory = new FactoryBaseZerg();
        break;
      default:
        factory = new FactoryBaseTerran();
        break;
    }
  }
}