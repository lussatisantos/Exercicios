using System;

class Exercicio09 {
    static void Main() {
        float dolar = 802;
        int kz;
        float conversor;

        Console.Write("Quantos kwanzas tens em carteira? ");
        kz = Convert.ToInt32(Console.ReadLine());
        
        conversor = kz / dolar;

        Console.Write("Voce consegue ter {0, 10} dolares", conversor);

    }
}