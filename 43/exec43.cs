using System;

namespace Exerc1{
        class Equacao {
        int delta = 0;
        int x1 = 0;
        int x2 = 0;
        public Equacao(int a, int b, int c){
                delta = b*b - (4 * a * c);
                if (delta < 0){
                    throw new Exception ("A equacao nao tem solucao");
                } else if(delta == 0){
                    throw new Exception("A equcao tem apenas uma solucao");
                } else {
                    Console.WriteLine("O valor do delta: {0}", delta);
                }
        }
    }
}

namespace Exerc2{
    class Equacao {
    int delta = 0;
    int x1 = 0;
    int x2 = 0;
    public Equacao(int a, int b, int c){
            delta = b*b - (4 * a * c);
            if (delta < 0){
                throw new Exception ("A equacao nao tem solucao");
            } else if(delta == 0){
                throw new Exception("A equcao tem apenas uma solucao");
            } else {
                Console.WriteLine("O valor do delta: {0}", delta);
            }
    }
}}

class Exercicio42 {
    static void Main(){

                try {
                    Equacao equacao = new Equacao(1, 2, 1);
                } catch (Exception e) {
                    Console.WriteLine("Atencao: " + e.Message);
                } finally {
                    Console.WriteLine("Fim do programa");
                }
    }
}