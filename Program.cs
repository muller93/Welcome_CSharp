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
      Selection selection = new Selection();

      //sum.summation();
      //copy.copping();
      //minimum.min();
      //sorting.sort();
      selection.sel();
    }
  }
}