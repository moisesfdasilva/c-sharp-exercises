public interface ICharacter
{
  void ObserverRegister(IObserver observer);
  void InformCharacters();
}