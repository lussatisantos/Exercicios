using System;

class Exercicio07 {
    static void Main() {
        int a, b, c;
        int delta, x1, x2;

        Console.WriteLine("............................");
        Console.WriteLine("...... EQUACAO 2 GRAU ......");
        Console.WriteLine("............................");

        Console.Write("Calcule o valor de a [x2]: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Calcule o valor de b [x]: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Calcule o valor de c [c]: ");
        c = Convert.ToInt32(Console.ReadLine());

        delta = (b*b) - (4 * a * c);

        if (delta == 0){
            x1 = - b + delta ** (1/2);
            x2 = x1;
            Console.WriteLine(x1);
        } else {
            x1 = - b + delta ** (1/2);
        }

        Console.WriteLine(x1);
    }
}