public abstract class Soldier
{
  public string Gun { get; protected set; }
  public string Transportation { get; protected set; }
  public string Attention { get; protected set; }

  public abstract void SelectGun(string gun);
  public abstract void SelectTransportation(string transportation);
  public abstract void DefineAttention(string attention);
}