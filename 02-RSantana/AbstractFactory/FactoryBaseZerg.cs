public class FactoryBaseZerg : IFactoryBase
{
  public FactoryBaseZerg()
  {
    CreateBase();
  }
  public void CreateBase()
  {
    Console.WriteLine("New Zerg base successfuly created!");

    CoveringBaseZerg covering = new CoveringBaseZerg();
    covering.Composition();

    EnergyBaseZerg energy = new EnergyBaseZerg();
    energy.Composition();
  }
}
