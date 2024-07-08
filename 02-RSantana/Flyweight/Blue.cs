public class Blue : Turtle
{
  public Blue()
  {
    this.condiction = " tutle inside shell, ";
    this.action = "spinning on the floor - ";
  }

  public override void Show(string someColor)
  {
    this.color = someColor;
    Console.WriteLine(condiction + action + color.ToUpper());
  }
}
