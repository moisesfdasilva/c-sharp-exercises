public class Context
{
  private State _state;

  public Context(State state)
  {
    this._state = state;
  }

  public State State
  {
    get { return _state; }
    set
    {
      _state = value;
      Console.WriteLine("Now the behavior is " + _state.GetType().Name);
    }
  }

  public void Replace()
  {
    _state.Action(this);
  }
}