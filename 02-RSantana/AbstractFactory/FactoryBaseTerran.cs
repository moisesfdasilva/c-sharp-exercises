public class FactoryBaseTerran : IFactoryBase
{
  public FactoryBaseTerran()
  {
    CreateBase();
  }
  public void CreateBase()
  {
    Console.WriteLine("New Terran base successfuly created!");

    CoveringBaseTerran covering = new CoveringBaseTerran();
    covering.Composition();

    EnergyBaseTerran energy = new EnergyBaseTerran();
    energy.Composition();
  }
}
