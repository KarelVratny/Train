using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train;
public class Locomotive {
    private Person driver;
    private Engine engine;

    public Person Driver { get => driver; set => driver = value; }
    public Engine Engine { get => engine; set => engine = value; }

    public Locomotive() { }
    public Locomotive(Person driver, Engine engine) {
        this.driver = driver;
        this.engine = engine;
    }
    public override string ToString() {
        return $"Vlak {Engine}, strojvudce: {Driver}";
    }
}