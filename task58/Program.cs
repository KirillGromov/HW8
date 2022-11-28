

int[] RequestSize(){
    int m = 2;
    int n = 2;
    int[] arr = {m, n};
    return arr;
}

void RequestNumsInArr(int[] arr){

    Random ran = new Random();

    int[,] arra1 = new int[arr[0], arr[1]];
    int[,] arra2 = new int[arr[0], arr[1]];
    for(int i = 0; i<arr[0]; i++){
        for(int j = 0; j<arr[1]; j++){
            arra1[i, j] = ran.Next(0, 10);
            arra2[i, j] = ran.Next(0, 10);
        }
    }

    ShowArr(arra1);
    ShowArr(arra2);
    int[,] Matrix = SummMatrix(arra1, arra2);
    Console.WriteLine("Результирующая матрица будет: ");
    Console.WriteLine();
    ShowArr(Matrix);
}

void ShowArr(int[,] arr1){

    for(int i = 0; i<arr1.GetLength(0); i++){
        for(int j = 0; j<arr1.GetLength(1); j++){
            Console.Write(" " + arr1[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}

int[,] SummMatrix(int[,] arr1, int[,] arr2){

    for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    arr1[i, j] = arr1[i, j] * arr2[i, j];
                }
                
            }
    return arr1;
}

RequestNumsInArr(RequestSize());


