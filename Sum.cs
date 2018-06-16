class Sum
  {
    public void summation()
    {
      int[] numbers = { 5, 3, 7, 8, 1 };
      int[] sum = new int[1];

      for (int i = 0; i < numbers.Length; i++)
      {
        sum[0] += numbers[i];
      }
      System.Console.WriteLine(sum[0]);
    }
  }
