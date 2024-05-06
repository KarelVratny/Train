using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train;
public class TestTrain {
    public static void Mainx() {
        BussinessWagon business1 = new BussinessWagon(new Person("Lenka", "Kozakova"), 10);
        NightWagon night1 = new NightWagon(10, 10);
        Hopper hopper1 = new Hopper(10);
        List<IWagon> wagons1 = new List<IWagon>() { business1, night1, hopper1 };
        try {
            Locomotive locomotive1 = new Locomotive(new Person("Karel", "Novak"), new Engine("diesel"));
            Train train1 = new Train(locomotive1, wagons1);
            Hopper hopper2 = new Hopper(20);
            hopper2.ConnectToTrain(train1);
            Console.WriteLine(train1);
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
    }
}

