public class Aggregate : IAggregate
{
  List<string> collection = null;
  
  public Aggregate()
  {
    collection = new List<string>();
  }

  public IIterator GetIterator()
  {
    return new Iterator(this);
  }

  public string this[int indexItem]
  {
    get
    {
      if (indexItem < collection.Count)
      {
        return collection[indexItem];
      }
      else
      {
        return string.Empty;
      }
    }
    set
    {
      collection.Add(value);
    }
  }

  public int Count
  {
    get
    {
      return collection.Count;
    }
  }
}