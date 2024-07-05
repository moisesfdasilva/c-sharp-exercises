public class CreateInfantarySoldier : CreateSoldier
{
  public CreateInfantarySoldier()
  {
    _soldier = new InfantrySoldier();
  }
  public override void Gun()
  {
    _soldier.SelectGun("air strike");
  }
  public override void Transportation()
  {
    _soldier.SelectTransportation("helicopter of army");
  }
  public override void Attention()
  {
    _soldier.DefineAttention("air rapid response");
  }
}