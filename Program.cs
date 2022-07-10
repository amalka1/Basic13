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



