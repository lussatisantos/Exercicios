using System;

class Execircio12 {
    static void Main() {
        int valor = 10;
        int Triplo;
        int teste;
        teste = Dobro(valor, out Triplo);

        Console.WriteLine("O valor {0} tem o seu  dobro {1} e o quadruplo {2}", valor, teste, Triplo);

    }

    static int Dobro(int dobr, out int triplo){
        int dobro;
        dobro = dobr * 2;
        triplo = dobro * 2;

        return dobro;
    }
}