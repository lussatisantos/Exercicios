using System;

class Apple {
    public int produtos;
    public string nome;

    public Apple() {
        produtos = 4;
        nome = "iPhone";
    }

    /*
    public string Apple(string n, out int dobro) {
        nome = n;
        produtos = 4;
        dobro = produtos * 2;
    }
    */

    
}

class Exercicio19 {
    static void Main() {

        Apple apple1 = new Apple();

        Console.WriteLine(apple1);

    }
}