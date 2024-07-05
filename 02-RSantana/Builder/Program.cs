class Program
{
  static void Main(string[] args)
  {
    Army army = new Army();
    CreateSoldier createSoldier;
    Soldier soldier;

    createSoldier = new CreateSpecialForceSoldier();
    army.ConstructSoldier(createSoldier);
    soldier = createSoldier.GetSoldier();
    Console.WriteLine("Characteristics of the soldier: {0}, {1}, {2}",
      soldier.Gun, soldier.Transportation, soldier.Attention);

    createSoldier = new CreateInfantarySoldier();
    army.ConstructSoldier(createSoldier);
    soldier = createSoldier.GetSoldier();
    Console.WriteLine("Characteristics of the soldier: {0}, {1}, {2}",
      soldier.Gun, soldier.Transportation, soldier.Attention);
  }
}