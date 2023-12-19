using System;

class Home {
    public int bedroom;
    public int sitting;
    public int kitchen;
    public int bath;

    public Home() {
        bedroom = 1;
        sitting = 1;
        kitchen = 1;
        bath = 1;
    }

    public void info() {
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");    
        Console.WriteLine("-=-=-=-=-=-=-=-  WELCOME AT HOME  -=-=-=-=-=-=-=-");
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
    }
}

class Exercise20 {
    static void Main() {

        Home home1 = new Home();

        home1.info();
    }
}