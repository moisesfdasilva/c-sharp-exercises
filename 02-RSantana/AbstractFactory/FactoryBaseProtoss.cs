public class FactoryBaseProtoss : IFactoryBase
{
  public FactoryBaseProtoss()
  {
    CreateBase();
  }
  public void CreateBase()
  {
    Console.WriteLine("New Protoss base successfuly created!");

    CoveringBaseProtoss covering = new CoveringBaseProtoss();
    covering.Composition();

    EnergyBaseProtoss energy = new EnergyBaseProtoss();
    energy.Composition();
  }
}
