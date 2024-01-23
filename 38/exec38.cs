using System;

class Mat {
    public int fatorial(int num){
        int resultado = num;
        if(resultado < 1){
            resultado = 1;
        } else {
            resultado *= fatorial(resultado - 1);
        }

        return resultado;
    }
}

class Exercicio38 {
    static void Main(){
        Mat mat = new Mat();

        Console.WriteLine(mat.fatorial(5)); 
    }
}