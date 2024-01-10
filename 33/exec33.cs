using System;

public interface Veiculo {
    void ligar();
    void desligar();
}

class Carro:Veiculo {
    public Carro(){}
    public void desligar(){}
    public void ligar(){}
}

class Exercicio33 {
    static void Main(){
        Carro carro = new Carro();
    }
}