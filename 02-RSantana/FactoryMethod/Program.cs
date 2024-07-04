class Program
{
  static void Main(string[] args)
  {
    FactoryMethod fm = new FactoryMethod();

    Console.WriteLine("Liu Kang | Sub Zero | Scorpion");
    Console.Write("Choose your character: ");

    ICharacter character = fm.Chosse_Character(Console.ReadLine());

    Console.Write("You are going to play with ");
    character.Chosen();
  }
}