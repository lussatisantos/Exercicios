using System;

class Veiculo {
    private int rodas;
    protected bool motor;
    public int velMax;

    public int getRodas() {
        return rodas;
    }

    public void setRodas(int roda) {
        rodas = roda;
    }
    
    public Veiculo() {
        rodas = 4;
        velMax = 120;
    }
}

class Carro:Veiculo {
    public string nome;

    public Carro(string nome) {
        this.nome = nome;
        motor = false;
    }
}

class Tanque:Carro {
    public string nom;

    public bool moto() {
        return motor;
    }

    public Tanque(string no):base("Camiao"){
        this.nom = no;
        setRodas(8);
    }
}

class Exercicio26 {
    static void Main() {
        Carro car = new Carro("Mercedes");
        Tanque tanque = new Tanque("Camiao F4");

        Console.WriteLine(car.nome);
        Console.WriteLine(car.getRodas());
        Console.WriteLine(tanque.moto());
        Console.WriteLine(tanque.getRodas());
    }
}