class Sorting{
int[] mainArray = {3,65,1,53,2,45,23,612,4,77,8};
int min = 1;
  public void sort(){
    for(int i = 0; i < mainArray.Length; i++){
      min = i;
      for(int j = i + 1; j < mainArray.Length; j++) {
        if (mainArray[j] < mainArray[min]) {
          min = j;
        }
      }
      if (min != i){
        int[] temp = new int[1];
        temp[0] = mainArray[i];
        mainArray[i] = mainArray[min];
        mainArray[min] = temp[0];
      }
      System.Console.WriteLine(mainArray[i]);
    }
  }
}