class Copy {

  public void copping(){
    int[] fromArray = {3, 55, 33, 15, 56, 23, 64, 23};
    int[] destinationArray = new int[fromArray.Length];
    for(int i = 0; i < fromArray.Length; i++){
      destinationArray[i] = fromArray[i];
      System.Console.WriteLine(destinationArray[i]);
    }
  }

}