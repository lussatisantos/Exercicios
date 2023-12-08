using System;

public class Carro {
    public string nome = "Mercedes";
    public int potencia = 400;
    public int velMax = 2000;
}

class Exercicio14 {
    
    static void Main(){

        Carro carro1 = new Carro();
        Carro carro2 = new Carro();
        Carro carro3 = new Carro();
        Carro carro4 = new Carro();

        if(carro1.nome == carro2.nome && carro3.nome == carro4.nome) {
            carro2.nome = "Ferrari";
            carro3.nome = "Lamborghini";
            carro4.nome = "Bughatti";
        }

    
        Console.WriteLine("A marca do carro é {0}", carro1.nome);
        Console.WriteLine("A marca do carro é {0}", carro2.nome);
        Console.WriteLine("A marca do carro é {0}", carro3.nome);
        Console.WriteLine("A marca do carro é {0}", carro4.nome);
       

    }
}