 // Print all of the integers from 1 to 255.
static void PrintNumbers()
{
   for (int i = 1; i<= 255; i++){
    System.Console.WriteLine(i);
   }
}

// Print all of the odd integers from 1 to 255.
static void PrintOdds()
{
     for (int i = 1; i<= 255; i++){
        if (i % 2 != 0){
    System.Console.WriteLine(i);
    }
   }
} //#3
static void PrintSum(){
    int sum=0;
    for (int i = 0; i<266; i++){
        sum+=i;
        System.Console.WriteLine("New number: " + i + " Sum: " + sum);
    }
}

//#4
static void LoopArray (int[] numbers){
    foreach(int vlera in numbers){
        System.Console.WriteLine(vlera);

    }
}
//#5. Find Max
static int FindMax(int[] numbers){
    int max = numbers[0];
    foreach(int value in numbers ){
        if (value > max ){
            max = value ;
        }
    }
    return max;
}
// #6. Get average 
static void GetAverage(int [] numbers){
    int sum = 0;
    foreach( int value in numbers ){
        sum+=value;
    }
    double avg = (double) sum / numbers.Length;
    System.Console.WriteLine(avg);

}
// #7. Array with Odd numbers 
static int [] OddArray(){
    int[] oddarr = new int[128]; 
    for (int i = 1; i < 266; i++ ){
        if (i % 2 != 0 ){
            for(int k = 0; k<oddarr.Length;k++ ){
                oddarr[k]=i;
            }
           
        }

    }
}
// #8. Greater than Y
static int GreaterThanY( int[] numbers, int y ){
    int count=0;
    foreach (int value in numbers ){
        if (value > y){
            count = count +1;
        }
    }
    return count;
}
 //#9. Square the values

 static void SquareArrayValues(int[] numbres){
    for(int i = 0; i < numbres.Length; i++){
       numbres[i] = numbres[i] * numbres[i];
       System.Console.WriteLine(numbres[i]);
    }
 }

 //#10. Eleminate negative numbers 

 static void EleminateNegativeNumbers(int [] numbers ){
    for (int i = 0; i < numbers.Length; i++ ){
        if (numbers[i] < 0){
            numbers [i] = 0;
        }
    }
 }

// #11. MIn Max and Average

static void MinMaxAvg( int [] numbres){
    int min = numbres[0];
    int max = numbres [0];
    int sum =0;
    for (int i = 0; i<numbres.Length; i++){
        if(numbres[i] < min){
            min = numbres[i];
        }
        if (numbres[i] > max ){
            max = numbres[i];
        }
        sum+=i;
    }
    double avg = (double) sum / numbres.Length;
    System.Console.WriteLine("Max number is: " + max +"\n Min number is: " + min + "\n Average is: " + avg  );
}

// #12. Shifting tha value in an array
static void ShiftValues(int[]numbers){
    for (int i = 0; i < numbers.Length; i++ ){
        numbers [i] = numbers[i+1]; 
    }
    numbers[numbers.Length - 1] = 0;
}

// #13. Number to String
static object[] NumToStrings(int [] numbers){
    object [] objectarr = new object [numbers.Length];
    for (int i = 0; i < numbers.Length; i++){
        if (numbers[i] < 0 ){
            objectarr[i] = "Dojo";
        }else{
            objectarr[i] = numbers[i];
        }
    }
    return objectarr;
}


