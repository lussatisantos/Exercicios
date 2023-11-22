using System;

class Exercicio05 {

    static void Main() {
        int num, opc;

        Console.WriteLine("................................");
        Console.WriteLine("... TABUADA DE MULTIPLICACAO ...");
        Console.WriteLine("................................");
        
        Console.Write("Digite o numero: ");
        num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Pretendes saber a tabuada de: {0}", num);

        

        for(int i = 1; i < 13; i++){
            Console.WriteLine("{0} x {1} = {2}", num, i, num * i);
        }

        Console.WriteLine("................................");
    }   
}