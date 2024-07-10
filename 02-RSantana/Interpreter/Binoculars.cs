public class Binoculars : ITool
{
  public void Interpreter(Context context)
  {
    context.Content += string.Format(" {0} ", " Binoculars ");
  }
}
