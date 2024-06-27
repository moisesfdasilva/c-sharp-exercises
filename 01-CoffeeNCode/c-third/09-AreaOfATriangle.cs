public class AreaOfATriangle
{
  /*
  Ask user width and height, store them
  Create function to calculate the area
  Function should calculate the area using: width * height / 2
  Call in main and print out the area of triangle
  */
  public static void RunAreaOfATriangle()
  {
    Console.Write("Enter width of triangle: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter height of triangle: ");
    int b =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Area of triangle is {Calculate(width: a, height: b)}.");
  }

  static int Calculate(int width, int height)
  {
    return width * height / 2;
  }
}