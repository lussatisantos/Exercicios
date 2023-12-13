using System;

class Carro {
    public string marca;
    public int rodas;
    public int velocidade;

    public void info() {
        Console.WriteLine("A marca do carro.....: {0}", marca);
        Console.WriteLine("A rodas do carro.....: {0}", rodas);
        Console.WriteLine("A velocidade do carro: {0}\n", velocidade);
    }

    public Carro() {
        marca = "Mercedes";
        rodas = 4;
        velocidade = 320;
    }

    public Carro(int v) {
        marca = "Mercedes";
        rodas = 4;
        velocidade = v;
    }

    public Carro(string nome, int v) {
        marca = nome;
        rodas = 4;
        velocidade = v;
    }
}

class Aula17 {
    static void Main() {
        Carro carro1 = new Carro();
        Carro carro2 = new Carro(200);
        Carro carro3 = new Carro("Lamborghini", 400);

        carro1.info();
        carro2.info();
        carro3.info();
    }
}