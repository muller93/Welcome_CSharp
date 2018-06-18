using System.Collections;

class Selection
{
  public void sel()
  {
    int i = 0;
    int num = 3;
    int[] array = {1, 8, 12, 7, 6, 3, 5 ,17, 13};

    while(i < array.Length && array[i] != num) {
      i++;
    }
    if (i < array.Length) {
      System.Console.WriteLine("There is such element, this is the " + (i + 1)+ ".");
    } else {
      System.Console.WriteLine("There isn't such element.");
    }
  }
}