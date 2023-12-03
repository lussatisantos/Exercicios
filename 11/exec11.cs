using System;

class Exercicio10 {
    static void Main() {
        string resp = "yes";
        string res = "";
        string[] capital = new string[12];

        capital[0] = "Luanda";
        capital[1] = "Nairobi";
        capital[2] = "Pretoria";
        capital[3] = "Cairo";
        capital[4] = "Argel";
        capital[5] = "Kigali";
        capital[6] = "Kinshasa";
        capital[7] =  "Windhoek";
        capital[8] = "Tunis";
        capital[9] = "Brazaville";
        capital[10] = "Abidjan";
        capital[11] = "Lagos";

        Console.Write("Enter a african capital: ");
            res = Console.ReadLine();
        
            foreach (string n in capital){
                if(res == n){
                    Console.WriteLine("Congrats!");
                }
            }

        /*
        WITH LOOP

        while(resp == "yes" || resp == "y" || resp == "Yes"){
            Console.Write("Enter a african capital: ");
            res = Console.ReadLine();
        
            foreach (string n in capital){
                if(res == n){
                    Console.WriteLine("Congrats!");
                }
            }

            Console.Write("Do you want to continue? ");
            resp = Console.ReadLine();
        }
       */

        /*
        if(res == "luanda" || res == "Luanda" || res == "luandA" || res == "lUanda"){
            Console.WriteLine("Parabens voce acertou!!!");
        }else if(resp == "luamda" || resp == "Luamda" || res == "luamdA" || res == "lUamda") {
            Console.WriteLine("Estas de parabens, mas tenha atencao na grafia LUANDA e nao LUAMDA");
        } else {
            Console.WriteLine("Desculpe, mas voce ERROU");
        }
        */

    }
}