using System;

class Carro {
    public string nome;
    public int rodas;
    public int velMax;

    public void Fast(string nome){
        this.nome = nome;

        Console.WriteLine("O nome do carro: {0}", this.nome);
    }

    public void Fast(string nome, int velMax){
        this.nome = nome;
        this.velMax = velMax;

        Console.WriteLine("O nome do carro: {0}", this.nome);
        Console.WriteLine("A velocidade Max: {0}", this.velMax);
    }

    public void Fast(string nome,int rodas, int velMax){
        this.nome = nome;
        this.velMax = velMax;

        Console.WriteLine("O nome do carro: {0}", this.nome);
        Console.WriteLine("O carro tem rodas: {0}", this.rodas);
        Console.WriteLine("A velocidade Max: {0}", this.velMax);
    }
}


class Exercicio37 {
    static void Main(){
        Carro carro = new Carro();

        Console.WriteLine("--------------------------------------");   
        carro.Fast("Mercedes"); 
        Console.WriteLine("--------------------------------------");     
        carro.Fast("Lamborghini", 180); 
        Console.WriteLine("--------------------------------------");
        carro.Fast("Porshe", 4, 240);
        Console.WriteLine("--------------------------------------");
    }
}