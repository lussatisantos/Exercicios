using System;

class Exercicio41 {
    static void Main(string[] args){
        if(args.Length < 0){
            Console.WriteLine("Voce nao passou nenhum parametro");
        } else {
            Console.Write("Voce digitou: ");
            for(int i = 0; i < args.Length; i++){
                Console.WriteLine(args[i]);
            }
            
            int num = 0;
            for(int i = 0; i < args.Length; i++){
                num = i;
            }
            Console.WriteLine("E contem {0} palavras", num);
        }
    }
}