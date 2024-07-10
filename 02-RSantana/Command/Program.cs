class Program
{
  static void Main(string[] args)
  {
    Control control = new Control();
    control.SendSimpleCommand(new SimpleCommand("Say Hello!"));

    Receiver receiver = new Receiver();
    control.SendComplexCommand(new ComplexCommand(receiver,
      "Fuel a car.", "Fill a tire."));
    
    control.RunCommands();
  }
}
