using System;

class Veiculo {
    private int velMax;

    public int vm {
        get {
            return velMax;
        }
        set {
            if(value < velMax) {
                velMax = value;
            } else if(velMax > 180){
                velMax = 180;
            }
        }
    }

    public Veiculo(){
        vm = 200;
    }
}

class Exercicio30 {
    static void Main(){
        Veiculo vel = new Veiculo();

        Console.WriteLine(vel.vm);
    }
}