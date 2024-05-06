using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train;
public class PersonalWagon {
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
    }
}