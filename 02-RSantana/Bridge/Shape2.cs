public class Shape2 : IShape
{
  public IColor IColor { get; set; }
  public string goDown()
  {
    return "U - " + IColor.Color();
  }
}