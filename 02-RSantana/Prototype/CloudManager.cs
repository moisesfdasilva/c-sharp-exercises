public class CloudManager
{
  private Dictionary<string, ShapeCloud> clouds = 
    new Dictionary<string, ShapeCloud>();

  public ShapeCloud this[string key]
  {
    get { return clouds[key]; }
    set { clouds.Add(key, value); }
  }
}