using System;

class Equipa {
    public int jogadores = 20;
    public string nome = "";
    public bool treinador = true;
    public bool adjunto = true;

    protected bool TreinInterino = false;

    private bool dividas = false;
    private bool fairPlayFinanceiro = false;
}

class Exercicio15 {
    static void Main() {

        Equipa eq1 = new Equipa();

        eq1.nome = "Barcelona";
        eq1.jogadores = 22;

        //Console.WriteLine(eq1.treinador);

        Equipa1();
    }

    public static void Equipa1() {
        Equipa equipa1 = new Equipa();

        equipa1.jogadores = 23;
        equipa1.nome = "Barcelona";

        if(equipa1.treinador == true) {
            Console.Write("Como se chama o treinador da equipa: ");
            string nomeTreinador = Console.ReadLine();
        }

        Console.WriteLine(equipa1.nome);
    }
}