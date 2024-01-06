using System;

class Carro{
    private int[] velMax = new int[2]{120, 180};

    public int this[int i]{
        get {
            return velMax[i];
        }
        set {
            if(value < 0) {
                velMax[i] = 0;
            } else if(value > 180) {
                velMax[i] = 180;
            } else {
                velMax[i] = value;
            }
        }
    }

    public Carro(){

    }
}

class Exercicio31 {
    static void Main(){
        Carro carro = new Carro();

        Console.WriteLine(carro[0]);
    }
}