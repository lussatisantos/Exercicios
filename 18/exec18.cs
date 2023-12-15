using System;

static class Pais {
    static public int provincias;
    static public int municipios;

    static public void Detalhe() {
        provincias = 10;
        municipios = 18;
    }

    static public void info() {
        Console.WriteLine(provincias);
        Console.WriteLine(municipios);
    }
}

class Exercicio18 {
    static void Main() {
        Pais.Detalhe();
        Pais.info();
    }
}