public class Bridge
{
  public IShape selected_shape { get; set; }
  public void ShowShape()
  {
    Console.WriteLine(selected_shape.goDown());
  }
}