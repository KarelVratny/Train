using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train;
public class Train {
    private Locomotive locomotive;
    private List<IWagon> wagons;

    public Locomotive Locomotive { get => locomotive; set => locomotive = value; }
    public List<IWagon> Wagons { get => wagons; set => wagons = value; }

    public Train() {
        this.wagons = new List<IWagon>();
    }
    public Train(Locomotive locomotive) : this() {
        this.locomotive = locomotive;
    }
    public Train(Locomotive locomotive, List<IWagon> wagons) : this(locomotive) {
        this.wagons = wagons;
    }
    public void ConnectToTrain(IWagon wagon) {
        wagon.ConnectToTrain(this);
    }
    public void DisconnectFromTrain(IWagon wagon) {
        wagon.DisconnectFromTrain(this);
    }
    public void ReserveChair(int wagon, int chair) {
        //if (wagons[wagon] is PersonalWagon) {
        //    ((PersonalWagon)Wagons[wagon]).Sits.Number == chair;
        //}
    }
    public void ListReservedChair() {
        string reservedChairs = "Seznam rezervovanych mist";
        int i = 0;
        foreach (PersonalWagon wagon in wagons) {
            if (wagon is PersonalWagon) {
                foreach (Chair chair in wagon.Sits) {
                }
            }
        }
    }
    public override string ToString() {
        string toString = $"{Locomotive}";
        foreach (IWagon wagon in this.Wagons) {
            toString += $"\n{wagon}";
        }
        return toString;
    }
}