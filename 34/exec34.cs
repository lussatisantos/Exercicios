using System;

struct Carro{
    public int rodas;
    public int velMax;

    public Carro(int rodas, int velMax){
        this.rodas = rodas;
        this.velMax = velMax;
    }
}

class Exercicio34 {
    static void Main(){
        Carro carro;
        carro.rodas = 4;
        carro.velMax = 120;

        Console.WriteLine(carro.rodas);
        Console.WriteLine(carro.velMax);
    }
}