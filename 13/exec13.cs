using System;

class Exercicio13{
    static void Main() {
        Soma(10, 10, 10, 10, 10);
    }

    static void Soma(params int[]num){
        int valor = 0;

        for(int i=0;i<num.Length;i++){
            valor += num[i];
        }
        Console.WriteLine("A soma dos valores sera: {0}", valor);

        Console.Write("Os numeros adicionados sao: ");
        foreach (int n in num){
            Console.Write("{0} ", n);
        }
    }
}
