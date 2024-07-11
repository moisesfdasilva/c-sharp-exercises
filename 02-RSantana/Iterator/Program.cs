class Program{
  static void Main(string[] args)
  {
    Aggregate collectionMaps = new Aggregate();

    collectionMaps[0] = "Map 1";
    collectionMaps[1] = "Map 2";
    collectionMaps[2] = "Map 3";
    collectionMaps[3] = "Map 4";
    collectionMaps[4] = "Map 5";

    IIterator iterator = collectionMaps.GetIterator();

    for (string s = iterator.firstItem; iterator.isReady == false;
      s = iterator.nextItem)
    {
      Console.WriteLine(s);
    }

    Console.ReadKey();
  }
}
