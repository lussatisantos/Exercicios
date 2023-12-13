using System;

class Carro {
    public string marca;
    public int rodas;
    public int velocidade;

    public void info() {
        Console.WriteLine("A marca do carro.....: {0}", marca);
        Console.WriteLine("A rodas do carro.....: {0}", rodas);
        Console.WriteLine("A velocidade do carro: {0}", velocidade);
    }

    public Carro() {
        marca = "Mercedes";
        rodas = 4;
        velocidade = 320;
    }
}

class Aula17 {
    static void Main() {
        Carro carro = new Carro();

        carro.info();
    }
}