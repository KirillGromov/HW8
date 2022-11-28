

int[] RequestSize(){
    Console.WriteLine("Введите размерность массива m n");
    int m = int.Parse(Console.ReadLine());
    int n = int.Parse(Console.ReadLine());
    int[] arr = {m, n};
    return arr;
}

void RequestNumsInArr(int[] arr){

    Random ran = new Random();

    int[,] arra = new int[arr[0], arr[1]];
    for(int i = 0; i<arr[0]; i++){
        for(int j = 0; j<arr[1]; j++){
            arra[i, j] = ran.Next(0, 10);
        }
    }

    ShowArr(arra);
    //SortArr(arra);
}

void ShowArr(int[,] arr){
    List<int> SummList = new List<int>();
    
    for(int i = 0; i<arr.GetLength(0); i++){
        int summ = 0;
        for(int j = 0; j<arr.GetLength(1); j++){

            Console.Write(" " + arr[i, j]);
            summ+=arr[i, j];
        }
        SummList.Add(summ);
        Console.WriteLine();
    }
    int[] ArrSum = SummList.ToArray();
    int min = ArrSum[0];
    int index = 0;
    for(int g = 0; g<ArrSum.Length; g++){
        if (min > ArrSum[g]){
                min = ArrSum[g];
 
                index = g;
        }
        
    }
    Console.WriteLine(index+1 + " строка");
}

RequestNumsInArr(RequestSize());


