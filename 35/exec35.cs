using System;

struct Carro {
    public string nome;

    public Carro(string nome){
        this.nome = nome;
    }

    public void info(){
        Console.WriteLine("O nome do Carro é: {0}", this.nome);
    }
}
 
class Exercicio35 {
    static void Main(){
        Carro[] carros = new Carro[4];

        carros[0] = new Carro("Mercedes");
        carros[0].info();

        carros[1] = new Carro("Lamborghini");
        carros[1].info();

        carros[2] = new Carro("Bugatti");
        carros[2].info();

        carros[3] = new Carro("Porshe");
        carros[3].info();
    }
}