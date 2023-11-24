using System;

class Exercicio06 {

    enum meses {
            Janeiro,
            Fevereiro,
            Marco,
            Abril,
            Maio,
            Junho,
            Julho,
            Agosto,
            Setembro,
            Outubro,
            Novembro,
            Dezembro
        }

    static void Main() {

        meses mes = meses.Julho;

        Console.WriteLine(mes);

        float dias = 12.7f;
        int dia = (int) dias;

        float months = 7.12f;
        int month = (int) months;

        int ano = 2003;

        Console.WriteLine(month);
        Console.WriteLine(dia);

        Console.WriteLine("Completo: dia {0} de {1} de {2} ", dia, mes, ano);

    }
}