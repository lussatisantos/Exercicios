using System;

class Militar {
    public string nome;
    private int bases;
    private bool nuclear;

    public Militar(string nome) {
        this.nome = nome;
        bases = 240;
        nuclear = true;
    } 

    public int getBases() {
        return bases;
    }

    public void setBases(int b) {
        if (b > 0) {
            bases += b;
        } else if(b < 0) {
            bases -= b;
        }
    }
}

class Exercicio23 {
    static void Main() {

        Militar M1 = new Militar("Academia Militar do Exercito do Lobito");

        M1.setBases(-1000);

        Console.WriteLine(M1.getBases());
    }
}