using System;
using System.Collections.Generic;

class Exercicio47 {
    static void Main(){

        Queue<string> q = new Queue<string>();

        q.Enqueue("a");
        q.Enqueue("e");
        q.Enqueue("i");
        q.Enqueue("o");
        q.Enqueue("u");
        
        
        foreach(string ab in q){
            Console.WriteLine("Letras: {0}",ab);
        }
    }
}