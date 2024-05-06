using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train;
public class PersonalWagon : IWagon {
    private List<Door> doors;
    private List<Chair> sits;
    private int numberOfChairs;

    public List<Door> Doors { get => doors; set => doors = value; }
    public List<Chair> Sits { get => sits; set => sits = value; }
    public int NumberOfChairs { get => numberOfChairs; set => numberOfChairs = value; }

    public PersonalWagon(int numberOfChairs) {
        this.numberOfChairs = numberOfChairs;
        sits = new List<Chair>(numberOfChairs);
        doors = new List<Door>();
        for (int i = 0; i < numberOfChairs; i++) {
            sits.Add(new Chair(i, true));
        }
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
}