public class Sword : ArmorShape
{
  string _description = "Strong Sword, ";
  ArmorShape _armorShape;

  public Sword(ArmorShape armorShape)
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