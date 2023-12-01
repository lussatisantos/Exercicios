using System;

class Exercicio08 {
    static void Main() {

        int [,] matriz = new int[4, 4];

        matriz[0, 0] = 10;
        matriz[0, 1] = 20;
        matriz[0, 2] = 30;
        matriz[0, 3] = 40;

        matriz[1, 0] = 11;
        matriz[1, 1] = 12;
        matriz[1, 2] = 13;
        matriz[1, 3] = 14;

        matriz[2, 0] = 21;
        matriz[2, 1] = 22;
        matriz[2, 2] = 23;
        matriz[2, 3] = 24;

        matriz[3, 0] = 31;
        matriz[3, 1] = 32;
        matriz[3, 2] = 33;
        matriz[3, 3] = 34;

        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 4; j++) {
                Console.Write("{0} ", matriz[i, j]);
            }
            Console.Write("\n");
        }
    }
}