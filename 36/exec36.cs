using System;

class Veiculo{
    public string nome;
    public int rodas;

    public Veiculo(string nome){
        this.nome = nome;
    }

    public Carro VeiCar(){
        return new Carro(string nome, int rodas);
    }
}

class Carro {
    public string nome;
    public int rodas;
    public int velMax;
    public Carro(string nome, int rodas, int velMax){
        this.nome = nome;
        this.rodas = rodas;
        this.velMax = velMax;

        Console.WriteLine("Marca do carro: {0}", this.nome);
        Console.WriteLine("rodas: {0}", this.rodas);
        Console.WriteLine("velMax: {0}", this.velMax);
    }
}

class Exercicio36 {
    static void Main(){
        Veiculo vel = new Veiculo();

        vel.VeiCar("Mercedes", 4, 240);
    }
}