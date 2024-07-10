class Enemy : IObserver
{
  private Cody observerCharacter;
  public void Alert(ICharacter character)
  {
    if (character == observerCharacter)
    {
      Console.WriteLine("Cody has hit and his life is : {0}",
        observerCharacter.getLife());
    }
  }
  public Enemy(Cody cody)
  {
    observerCharacter = cody;
    observerCharacter.ObserverRegister(this);
  }
}