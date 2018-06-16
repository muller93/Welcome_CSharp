using System;

namespace firstC_App
{
  class Program
  {
    static void Main(string[] args)
    {
      Sum sum = new Sum();
      Copy copy = new Copy();
      Minimum minimum = new Minimum();
      Sorting sorting = new Sorting();

      sum.summation();
      copy.copping();
      minimum.min();
      sorting.sort();
    }
  }
}
