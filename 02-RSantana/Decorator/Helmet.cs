public class Helmet : ArmorShape
{
  string _description = "Helmet, ";
  ArmorShape _armorShape;

  public Helmet(ArmorShape armorShape)
  {
    _armorShape = armorShape;
  }

  public override string Description
  {
    get
    {
      return _armorShape.Description + _description;
    }
  }
}