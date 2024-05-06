using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train;
public class Engine {
    private string type;

    public string Type { get => type; set => type = value; }

    public Engine(string type) {
        this.type = type;
    }
    public override string ToString() {
        return $"typ: {Type}";
    }
}