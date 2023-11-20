using System;

class Exercicio02 {
    static void Main() {
        
        double valorCompra = 40;
        double valorVenda;
        double lucro = 0.27;
        string produto = "Pasteis";

        valorVenda = valorCompra + (valorCompra * lucro);

        Console.WriteLine("Produto............:{0,10}", produto);
        Console.WriteLine("Val.Compra.........:{0,10:c}", valorCompra);
        Console.WriteLine("Lucro..............:{0,10:p}", lucro);
        Console.WriteLine("Val.Venda..........:{0,10:c}", valorVenda);

    }
}