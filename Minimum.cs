class Minimum {

  public void min(){
  int[] fromArray = {3,7,25,42,76,12,6};
  int[] minArray = new int[1];
  minArray[0] = fromArray[0];

  for(int i = 0; i < fromArray.Length; i++){
    while (fromArray[i] < minArray[0]) {
      minArray[0] = fromArray[i];
    }
  }
  System.Console.WriteLine(minArray[0]);
  }
}