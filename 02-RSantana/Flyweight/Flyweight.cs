public class Flyweight
{
  private Dictionary<string, Turtle> turtleList 
    = new Dictionary<string, Turtle>();
  public Turtle GetTurtle(string color)
  {
    Turtle turtle = null;
    if (turtleList.ContainsKey(color))
    {
      turtle = turtleList[color];
    }
    else
    {
      switch (color)
      {
        case "blue": turtle = new Blue(); break;
        case "green": turtle = new Green(); break;
        case "orange": turtle = new Orange(); break;
        case "red": turtle = new Red(); break;
      }
      turtleList.Add(color, turtle);
    }
    return turtle;
  }
}
