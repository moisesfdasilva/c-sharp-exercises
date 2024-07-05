public class CreateSpecialForceSoldier : CreateSoldier
{
  public CreateSpecialForceSoldier()
  {
    _soldier = new SpecialForceSoldier();
  }
  public override void Gun()
  {
    _soldier.SelectGun("assault rifle");
  }
  public override void Transportation()
  {
    _soldier.SelectTransportation("special force land vehicle");
  }
  public override void Attention()
  {
    _soldier.DefineAttention("ground combat");
  }
}