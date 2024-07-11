public class CharacterC : Manipulator
{
  public override void Replace(int powerQuantity)
  {
    if (powerQuantity >= 20 && powerQuantity < 30)
      Console.WriteLine("{0} select with {1} of power",
        this.GetType().Name, powerQuantity);
    else if (successor != null)
      successor.Replace(powerQuantity);
  }
}