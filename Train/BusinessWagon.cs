using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train;
public class BussinessWagon : PersonalWagon {
    private Person steward;

    public Person Steward { get => steward; set => steward = value; }

    public BussinessWagon(Person steward, int numberOfchairs) : base(numberOfchairs) {
        this.steward = steward;
    }
    public override string ToString() {
        return $"Business vagon. {NumberOfChairs} mist k sezeni. Stevard {Steward}";
    }
}