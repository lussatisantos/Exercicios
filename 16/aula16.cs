using System;

public class Pais {
    public string nome;
    public int provincias;
    public int municipios;

    public Pais() {
        nome = "Angola";
        provincias = 18;
        municipios = 164;
    }

    public void info() {
        Console.WriteLine("O nome do pais........: {0}", nome);
        Console.WriteLine("Provincias existentes.: {0}", provincias);
        Console.WriteLine("Municipios existentes.: {0}",municipios);
    }

}

class Aula16 {
    static void Main() {
        Pais Angola = new Pais();

        Angola.info();

    }
}