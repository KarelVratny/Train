using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train;
public class Hopper : IWagon {
    private double loadingCapacity;

    public double LoadingCapacity { get => loadingCapacity; set => loadingCapacity = value; }

    public Hopper(double tonnage) {
        this.loadingCapacity = tonnage;
    }
    public void ConnectToTrain(Train train) {
        if (train.Locomotive.Engine.Type == "parni" && train.Wagons.Count >= 5) {
            throw new Exception("Parni lokomotiva muze mit maximalne 5 vagonu.");
        }
        else {
            train.Wagons.Add(this);
        }
    }
    public void DisconnectFromTrain(Train train) {
        if (train.Wagons.Contains(this)) {
            train.Wagons.Remove(this);
        }
        else {
            Console.WriteLine("Vlak ktery jste chteli odpojit, neni pripojen k danemu vlaku");
        }
    }
    public override string ToString() {
        return $"Hopper, kapacita {LoadingCapacity} tun.";
    }
}