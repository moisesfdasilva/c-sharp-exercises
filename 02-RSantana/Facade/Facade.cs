public class Facade
{
  private SubsystemOne one;
  private SubsystemTwo two;
  private SubsystemThree three;

  public Facade()
  {
    this.one = new SubsystemOne();
    this.two = new SubsystemTwo();
    this.three = new SubsystemThree();
  }
  public void OperationA()
  {
    Console.WriteLine("\nOperation A ------");
    this.one.Responsability();
    this.two.Responsability();
  }
  public void OperationB()
  {
    Console.WriteLine("\nOperation B ------");
    this.three.Responsability();
  }
}
