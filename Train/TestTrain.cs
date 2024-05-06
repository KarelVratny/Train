using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train;
public class TestTrain {
    public static void Mainx() {
        //1
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
        //2
        List<IWagon> wagons2 = new List<IWagon>() { new EconomyWagon(10), new EconomyWagon(10), new EconomyWagon(10), new EconomyWagon(10), new EconomyWagon(10) };
        EconomyWagon economy1 = new EconomyWagon(10);
        try {
            Locomotive locomotive2 = new Locomotive(new Person("Jan", "Svoboda"), new Engine("parni"));
            Train train2 = new Train(locomotive2, wagons2);
            Console.WriteLine(train2);
            train2.ConnectToTrain(economy1);
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
        //3
    }
}

