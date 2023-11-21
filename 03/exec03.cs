using System;

class Exericio03 {
    static void Main() {
        
        int num;
        int dobro;
        int metade;

        Console.WriteLine("Analise qualquer numero para ver o seu dobro e a sua metade");
        Console.Write("Digite: ");

        //num = Console.ReadLine();
        num = int.Parse(Console.ReadLine());
        //num = Convert.ToInt32(Console.ReadLine())

        dobro = num << 1;
        metade = num >> 1;

        Console.WriteLine("O dobro de {0} sera {1}", num, dobro);
        Console.WriteLine("A metade de {0} sera {1}", num, metade);

    }
}