class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine(" ### Standard Armor ###");
    ArmorShape armor = new StandardArmor();
    Console.WriteLine("Description: " +
      armor.Description.TrimEnd(' ', ','));

    Console.WriteLine(" ### More itens in the armor ###");
    armor = new Helmet(armor);
    armor = new Sword(armor);

    Console.WriteLine("Description: " +
      armor.Description.TrimEnd(' ', ','));
  }
}