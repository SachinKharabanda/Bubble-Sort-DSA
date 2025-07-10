int[] BubbleSort(int[] x) {

    for (int i = 0; i < x.Length; i++) { 
    
        for (int j = 0; j < x.Length-1; j++) {

            if (x[j+1] < x[j]) {
                int temp = x[j];
                x[j] = x[j+1];
                x[j+1] = temp;
            }
        }
    
    }

    return x;
}

int[] a = { 7, 12, 9, 11, 3 };
a = BubbleSort(a);
foreach (int b in a) {Console.Write(b + ",");}