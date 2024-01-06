using System;

class Equipa {
    private int[] onze = new int[2]{11, 8};

    public int this[int i]{
        get {
            return onze[i];
        }
    }

    public Equipa(){

    }
}

class Exercicio32 {
    static void Main(){
        Equipa equipa = new Equipa();

        Console.WriteLine(equipa[0]);
    }
}