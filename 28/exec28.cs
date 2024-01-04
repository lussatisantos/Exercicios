using System;

abstract class Veiculo {

    public Veiculo() {
        Console.WriteLine("Classe abstracta veiculo");
    }

    abstract public void info();
}

class Carro:Veiculo {
    override public void info() {
        Console.WriteLine("Testando metodo abstracto e a sua subscricao");
    }
}

class Exercicio28 {
    static void Main() {
        Carro carro = new Carro();

        carro.info();
    }
}