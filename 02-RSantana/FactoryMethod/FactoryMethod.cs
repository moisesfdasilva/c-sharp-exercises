public class FactoryMethod
{
  public ICharacter Chosse_Character(string character)
  {
    switch (character)
    {
      case "Liu Kang": return new LiuKang();
      case "Sub Zero": return new SubZero();
      case "Scorpion": return new Scorpion();
      default: return new LiuKang();
    }
  }
}

