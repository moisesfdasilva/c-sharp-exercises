class Program
{
  static void Main(string[] args)
  {
    Manipulator characterA = new CharacterA();
    Manipulator characterB = new CharacterB();
    Manipulator characterC = new CharacterC();

    characterA.defineSuccessor(characterB);
    characterB.defineSuccessor(characterC);

    int[] requests = { 5, 8, 15, 20, 18, 3, 27, 20 };

    foreach (int req in requests)
    {
      characterA.Replace(req);
    }

    Console.ReadKey();
  }
}