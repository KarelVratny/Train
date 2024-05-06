using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train;
public interface IWagon {
    public void ConnectToTrain(Train train);
    public void DisconnectFromTrain(Train train);
}
