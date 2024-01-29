using System;
using System.Collections.Generic;

class Exercicio46 {
    static void Main(){
        
        List <string> Carros = new List<string>();

        Carros.Add("Mercedes");
        Carros.Add("Lamborghini");
        Carros.Add("BMW");
        Carros.Add("Buggati");
        Carros.Add("Ferrari");

        foreach(string car in Carros){
            Console.WriteLine(car);
        }
    }
}