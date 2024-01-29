using System;
using System.Collections.Generic;

class Exercicio45 {
    static void Main(){

        LinkedList <string> list = new LinkedList<string>();

        list.AddFirst("C#");
        list.AddFirst("Python");
        list.AddLast("Java");
        list.AddLast("JavaScript");

        foreach (string lang in list){
            Console.WriteLine(lang);
        }
    }
}