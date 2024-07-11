public class Action
{
  private string _state;

  public string State
  {
    get { return _state; }
    set
    {
      _state = value;
      Console.WriteLine("State of fame = " + _state);
    }
  }

  public Memento CreateMemento()
  {
    return (new Memento(_state));
  }

  public void ResetState(Memento memento)
  {
    Console.WriteLine("Reseting the state...");
    State = memento.State;
  }
}