public interface IIterator
{
  string firstItem { get; }
  string nextItem { get; }
  string selectedItem { get; }
  bool isReady { get; }
}