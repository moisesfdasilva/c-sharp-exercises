public class Rope : ITool
{
  public void Interpreter(Context context)
  {
    context.Content += string.Format(" {0} ", " Rope ");
  }
}
