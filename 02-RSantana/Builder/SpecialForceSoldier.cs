public class SpecialForceSoldier : Soldier
{
  public override void SelectGun(string gun)
  {
    Gun = gun;
  }
  public override void SelectTransportation(string transportation)
  {
    Transportation = transportation;
  }
  public override void DefineAttention(string attention)
  {
    Attention = attention;
  }
}