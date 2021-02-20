using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class Engine {
        private string type;        // to do: diesel, elektrická, parní

        public string Type { get => type; set => type = value; }
        
        public Engine(string type) {
            Type = type;
        }
        public override string ToString() {
            return "Engine type: " + Type;
        }

    }
}
