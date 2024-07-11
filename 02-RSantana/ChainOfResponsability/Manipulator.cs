public abstract class Manipulator
{
  protected Manipulator successor;

  public void defineSuccessor(Manipulator successor)
  {
    this.successor = successor;
  }

  public abstract void Replace(int PowerQuantity);
}