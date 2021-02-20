using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class NightWagon : PersonalWagon {
        private List<Bed> beds;
        private int numberOfBeds;

        public int NumberOfBeds { get => numberOfBeds; set => numberOfBeds = value; }
        internal List<Bed> Beds { get => beds; set => beds = value; }

        public NightWagon(int numberOfChairs, int numberOfBeds) : base(numberOfChairs) {
            NumberOfBeds = numberOfBeds;
            Beds = new List<Bed>();
            beds.Capacity = numberOfBeds;
        }
        public override string ToString() { 
            return base.ToString() + ", number of beds: " + NumberOfBeds;
        }
    }
}
