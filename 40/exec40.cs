using System;

delegate int Teste(int n1, int n2);
class Carro{
    public static int rodas = 10;
    public static int andar(int km, int min){
        return km * min;
    }

    public static int anda(int km, int min){
        return km - min;
    }
}

class Exercicio40 {
    static void Main(){
        Teste teste = new Teste(Carro.andar);
        int res = teste(10, 20);

        Console.WriteLine(res);


    }
}