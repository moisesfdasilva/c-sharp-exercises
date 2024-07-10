public class SimpleCommand : ICommand
{
  private string _solicitation = string.Empty;

  public SimpleCommand(string solicitation)
  {
    this._solicitation = solicitation;
  }

  public void Run()
  {
    Console.WriteLine("Simple command run " + this._solicitation);
  }
}