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
        train.Wagons.Add(this);
    }
    public void DisconnectFromTrain(Train train) {
        train.Wagons.Remove(this);
    }
    public override string ToString() {
        return $"Hopper, kapacita {LoadingCapacity} tun.";
    }
}