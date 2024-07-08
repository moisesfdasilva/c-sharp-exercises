public class ConcreteCloud : ShapeCloud
{
  private string fill_color;
  private string border_color;

  public ConcreteCloud(string fill, string border)
  {
    this.fill_color = fill;
    this.border_color = border;
  }

  public override ShapeCloud Clone()
  {
    Console.WriteLine("The clone of cloud have a border {0} and fill {1}.",
      this.border_color, this.fill_color);
    return this.MemberwiseClone() as ShapeCloud;
  }
}