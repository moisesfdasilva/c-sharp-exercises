public class CharacterB : Manipulator
{
  public override void Replace(int powerQuantity)
  {
    if (powerQuantity >= 10 && powerQuantity < 20)
      Console.WriteLine("{0} select with {1} of power",
        this.GetType().Name, powerQuantity);
    else if (successor != null)
      successor.Replace(powerQuantity);
  }
}