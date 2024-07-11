class Program
{
  static void Main(string[] args)
  {
    Action action = new Action();
    action.State = "play";

    Store store = new Store();
    store.Memento = action.CreateMemento();

    action.State = "pause";
    action.ResetState(store.Memento);

    Console.ReadKey();
  }
}