public class Iterator : IIterator
{
  IAggregate collection = null;
  int index = 0;

  public Iterator(IAggregate collection)
  {
    this.collection = collection;
  }

  public string firstItem
  {
    get
    {
      index = 0;
      return collection[index];
    }
  }

  public string nextItem
  {
    get
    {
      index += 1;

      if (isReady == false)
      {
        return collection[index];
      }
      else
      {
        return string.Empty;
      }
    }
  }

  public string selectedItem
  {
    get
    {
      return collection[index];
    }
  }

  public bool isReady
  {
    get
    {
      if (index < collection.Count)
      {
        return false;
      }
        return true;
    }
  }
}