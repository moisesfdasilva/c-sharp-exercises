public class Adapter : IAction
{
  Plane plane;
  public Adapter(Plane newPlane)
  {
    this.plane = newPlane;
  }
  public void Walk(string character)
  {
    this.plane.Fly(character);
  }
  public void Shoot()
  {
    this.plane.LaunchMissile();
  }
}