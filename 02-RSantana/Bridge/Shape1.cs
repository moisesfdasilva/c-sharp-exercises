public class Shape1 : IShape
{
  public IColor IColor { get; set; }
  public string goDown()
  {
    return "T - " + IColor.Color();
  }
}