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
        if (type == "diesel" || type == "elektricky" || type == "parni") {
            this.type = type;
        }
        else {
            throw new ArgumentException("Zadejte platny typ motoru (diesel, elektricky, parni)");
        }

    }
    public override string ToString() {
        return $"typ: {Type}";
    }
}