public class CharacterA : Manipulator
{
  public override void Replace(int powerQuantity)
  {
    if (powerQuantity >= 0 && powerQuantity < 10)
      Console.WriteLine("{0} select with {1} of power",
        this.GetType().Name, powerQuantity);
    else if (successor != null)
      successor.Replace(powerQuantity);
  }
}