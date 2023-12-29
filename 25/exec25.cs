using System;

class Jogador {
    public bool pEsquerdo = false;
    public bool pDireito = false;
    public bool avancador = true;
}

class Equipa:Jogador {

}

class Exercicio25 {
    static void Main() {
        Equipa equipa = new Equipa();

        Console.WriteLine(equipa.avancador);
    }
}