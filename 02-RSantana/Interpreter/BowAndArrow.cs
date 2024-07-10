public class BowAndArrow : IWeapon
{
  public void Interpreter(Context context)
  {
    context.Content += string.Format(" {0} ", " Bow and arrow ");
  }
}
