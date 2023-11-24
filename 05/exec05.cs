using System;

class Exercicio05 {

    static void Main() {
        int num, opc, nada;

        Console.WriteLine("................................");
        Console.WriteLine("... TABUADA DE MULTIPLICACAO ...");
        Console.WriteLine("................................");
        
        Console.Write("Digite o numero: ");
        num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Pretendes saber a tabuada de: {0}", num);

        Console.WriteLine("1 - Multiplicao");
        Console.WriteLine("2 - Divisao");
        Console.WriteLine("3 - Adicao");
        Console.WriteLine("4 - Subtracao");

        Console.Write("Digite uma opcao: ");
        opc = Convert.ToInt32(Console.ReadLine());

        if (opc == 1) {
            for(int i = 1; i < 13; i++){
                Console.WriteLine("{0} x {1} = {2}", num, i, num * i);
            }
        } else if (opc == 2) {
            for(int i = 1; i < 13; i++){
                Console.WriteLine("{0} x {1} = {2}", num, i, num / i);
            }
        } else if (opc == 3) {
            for(int i = 1; i < 13; i++){
                Console.WriteLine("{0} x {1} = {2}", num, i, num + i);
            }
        } else if (opc == 4) {
            for(int i = 1; i < 13; i++){
                Console.WriteLine("{0} x {1} = {2}", num, i, num - i);
            }
        } else {
            Console.WriteLine("Opcao invalida, por favor digite uma opcao valida!!!");
        }

        Console.WriteLine("................................");
    
        nada = Convert.ToInt32(Console.ReadLine());
    }
    
}