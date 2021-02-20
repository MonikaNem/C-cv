using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class BusinessWagon : PersonalWagon {
        private Person steward;

        internal Person Steward { get => steward; set => steward = value; }
        
        public BusinessWagon(int numberOfChairs, Person steward) : base(numberOfChairs) {
            Steward = steward;
        }
        public override string ToString() {
            return base.ToString() + ", steward: " + Steward.ToString();
        }
    }
}
