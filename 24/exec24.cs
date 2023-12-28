using System;

class Agua {
    private bool solido;
    private bool liquido;
    private bool gasoso;

    public Agua() {
        solido = false;
        gasoso = false;
        liquido = true;
    }

    public bool getLiquido() {
        return liquido;
    }
}

class Exercicio24 {
    static void Main() {
        Agua agua = new Agua();

        Console.WriteLine(agua.getLiquido());
    }
}