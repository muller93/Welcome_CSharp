class Counter{
  public void count(){
    int[] array = {1,2,3,4,5,6,7,8,9,10};
    int counter = 0;

    for(int i = 0; i < array.Length; i++){
      if(array[i] % 2 == 0){
      counter++;
      }
    }
    System.Console.WriteLine(counter);
  }
}