using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class Locomotive {
        private Person driver;
        private Engine engine;

        internal Person Driver { get => driver; set => driver = value; }
        internal Engine Engine { get => engine; set => engine = value; }
        public Locomotive() {
        }
        public Locomotive(Person driver, Engine engine) {
            Driver = driver;
            Engine = engine;
        }
        public override string ToString() {     //TO DO
            return  "Driver: " + Driver.ToString() + ", Engine: " + Engine.ToString();
        }
    }
}
