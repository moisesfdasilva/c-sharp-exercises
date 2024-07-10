public class Control
{
  private ICommand simpleCommand;
  private ICommand complexCommand;

  public void SendSimpleCommand(ICommand command)
  {
    this.simpleCommand = command;
  }

  public void SendComplexCommand(ICommand command)
  {
    this.complexCommand = command;
  }

  public void RunCommands()
  {
    Console.WriteLine("Ok, I will be run.");
    if (this.simpleCommand is ICommand)
      this.simpleCommand.Run();
    if (this.complexCommand is ICommand)
      this.complexCommand.Run();
  }
}