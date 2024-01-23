using System;

class Mat {
    public static int dobro(int x){
        return x * 2;
    }

    public static int triplo(int x){
        return x * 3;
    }
}

class Exercicio39 {
    static void Main(){
        int triplo = Mat.triplo(7);

        Console.WriteLine(Mat.dobro(10));
        Console.WriteLine(triplo);
    }
}