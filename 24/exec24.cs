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
}

class Exercicio24 {
    static void Main() {
        Agua agua = new Agua();
    }
}