public class ArmorDecorator : ArmorShape
{
  string _description = "Abstract Decorator Armor";

  public override string Description
  {
    get
    {
      return _description;
    }
  }
}