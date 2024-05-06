using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train;
public class NightWagon : PersonalWagon {
    private Bed[] beds;
    private int numberOfBeds;

    public Bed[] Beds { get => beds; set => beds = value; }
    public int NumberOfBeds { get => numberOfBeds; set => numberOfBeds = value; }
    public NightWagon(int numberOfChairs, int numberOfBeds) : base(numberOfChairs) {
        this.numberOfBeds = numberOfBeds;
        beds = new Bed[numberOfBeds];
    }
    public override string ToString() {
        return $"Nocni vagon. {NumberOfChairs} mist k sezeni. {NumberOfBeds} posteli";
    }
}