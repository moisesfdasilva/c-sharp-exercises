class Program
{
  static void Main(string[] args)
  {
    CloudManager cloudManager = new CloudManager();
    cloudManager["standart"] = new ConcreteCloud("white", "blue");
    cloudManager["customized"] = new ConcreteCloud("white", "orange");

    ConcreteCloud one = cloudManager["standart"].Clone() as ConcreteCloud;
    ConcreteCloud two = cloudManager["standart"].Clone() as ConcreteCloud;
    ConcreteCloud three = cloudManager["customized"].Clone() as ConcreteCloud;
  }
}
