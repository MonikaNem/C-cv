using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class Chair {
        private int number;
        private bool nearWindow;
        private bool reserved;

        public int Number { get => number; set => number = value; }
        public bool NearWindow { get => nearWindow; set => nearWindow = value; }
        public bool Reserved { get => reserved; set => reserved = value; }
        public Chair() {
        }
        //public override string ToString() {
        //    string res = "free";
        //    if (reserved == true) {
        //        res = "reserved";
        //    }
        //    return "Seat no. " + Number + "\t" + res;
        //}
    }
}
