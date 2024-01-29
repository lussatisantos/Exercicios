using System;
using System.Collections.Generic;

class Exercicio44 {
    static void Main(){

        Dictionary <int, string> d = new Dictionary<int, string>();

        d.Add(10, "Artigo");
        d.Add(11, "Artigo");
        d.Add(12, "Artigo");
        d.Add(13, "Artigo");
        d.Add(14, "Artigo");
        d.Add(9, "Artigo");

        foreach(KeyValuePair<int, string> k in d){
            Console.WriteLine(k);
        }

    }
}