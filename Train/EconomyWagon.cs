using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train;
public class EconomyWagon : PersonalWagon {
    public EconomyWagon(int numberOfchairs) : base(numberOfchairs) { }
    public override string ToString() {
        return $"Economy vagon. {NumberOfChairs} mist k sezeni.";
    }
}