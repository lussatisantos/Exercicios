using System;

class Vehicle {
    public Vehicle(){}

    virtual public void info(){}
}

class Car:Vehicle {
    public Car(){}

    override public void info() {
        Console.WriteLine("New information about this Car");
    }
}

class VehicleFight:Car {
    public VehicleFight() {
    }

    override public void info() {
        Console.WriteLine("Information about build Fight vehicle");
    }
}

class Exercicio27 {
    static void Main() {
        
        Vehicle Ref;

        Car car = new Car();
        VehicleFight fight = new VehicleFight();

        Ref = car;
        Ref.info();

        Ref = fight;
        Ref.info();

        /*
        car.info();
        fight.info();
        */
    }
}