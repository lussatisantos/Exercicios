using System;

class Exercicio10 {
    static void Main() {
        string resp = "";

        Console.Write("Digite a capital de Angola: ");
        resp = Console.ReadLine();

        if(resp == "luanda" || resp == "Luanda" || resp == "luandA" || resp == "lUanda"){
            Console.WriteLine("Parabens voce acertou!!!");
        }else if(resp == "luamda" || resp == "Luamda" || resp == "luamdA" || resp == "lUamda") {
            Console.WriteLine("Estas de parabens, mas tenha atencao na grafia LUANDA e nao LUAMDA");
        } else {
            Console.WriteLine("Desculpe, mas voce ERROU");
        }

        /*
            Exercicio proposto por Anita Lopes e Guto Garcia no livro
            500 Algoritmos Resolvidos pag77/78;
        */
    }
}