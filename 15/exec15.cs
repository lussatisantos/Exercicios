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
        Equipa2();
    }

    public static void Equipa1() {
        Equipa equipa1 = new Equipa();

        equipa1.jogadores = 23;
        equipa1.nome = "Barcelona";

        if(equipa1.treinador != false) {
            Console.Write("Como se chama o treinador da equipa: ");
            string nomeTreinador = Console.ReadLine();

        } else if (equipa1.treinador == false) {
            Console.Write("A equipa possui um treinador interino? [S/N]: ");
            string opc = Console.ReadLine();

            if(opc == "S"){
                equipa1.treinador = true;
            } else if(opc == "N"){
                Console.WriteLine("A equipa precisa de treinador ou um adjunto do clube devera ser o treinador interino");
            } else {
                Console.WriteLine("Opcao invalida, por favor digite uma opcao valida");
            }
        }

        if (equipa1.adjunto != true) {
            Console.WriteLine("Um treinador precisa de Adjuntos para ajuda-lo a tomar as melhores decisoes para a equipa");
        } else {
            Console.WriteLine("A equipa possui adjuntos");
        }
        Console.WriteLine(equipa1.nome);
    }

    public static void Equipa2() {
        Equipa equipa2 = new Equipa();

        equipa2.jogadores = 18;
        equipa2.nome = "Sporting CP";

        if(equipa2.treinador != false) {
            Console.Write("Como se chama o treinador da equipa: ");
            string nomeTreinador = Console.ReadLine();

        } else if (equipa2.treinador == false) {
            Console.Write("A equipa possui um treinador interino? [S/N]: ");
            string opc = Console.ReadLine();

            if(opc == "S"){
                equipa2.treinador = true;
            } else if(opc == "N"){
                Console.WriteLine("A equipa precisa de treinador ou um adjunto do clube devera ser o treinador interino");
            } else {
                Console.WriteLine("Opcao invalida, por favor digite uma opcao valida");
            }
        }

        if (equipa2.adjunto != true) {
            Console.WriteLine("Um treinador precisa de Adjuntos para ajuda-lo a tomar as melhores decisoes para a equipa");
        } else {
            Console.WriteLine("A equipa possui adjuntos");
        }
        Console.WriteLine(equipa2.nome);
    }
}