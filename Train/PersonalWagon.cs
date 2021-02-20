using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    abstract class PersonalWagon : IWagon {
        private List<Door> doors;
        private List<Chair> sits;
        private int numberOfChairs;
        //private Train train; 

        public int NumberOfChairs { get => numberOfChairs; set => numberOfChairs = value; }
        internal List<Door> Doors { get => doors; set => doors = value; }
        internal List<Chair> Sits { get => sits; set => sits = value; }
        //internal Train Train { get => train; set => train = value; }

        protected PersonalWagon(int numberOfChairs) {
            NumberOfChairs = numberOfChairs;
            Sits = new List<Chair>();
            Sits.Capacity = numberOfChairs;
            for (int i = 1; i <= Sits.Capacity; i++) {
                Sits.Add(new Chair());
                Sits[i-1].Number = i;
            }
        }
        public void ConnectWagon(Train train) {
            if (train.Locomotive.Engine.Type == "steam") {
                if (train.Wagons.Count < 5) {
                    train.Wagons.Add(this); // přirazení vagonu tomu danému vlaku - přidání do jeho kolekce vagonů
                }
                else {
                    Console.WriteLine("Capacity of this train is full (steam engine can have max 5 wagons).");
                }
            }
            else {
                train.Wagons.Add(this);
            }
            //this.Train = train; - přiřazení vagonu do vlastnosti Train toho vagonu (asi nemusí být)    
        }
        public void DisconnectWagon(Train train) {
            //this.Train = null;
            if (train.Wagons.Contains(this)) {
                train.Wagons.Remove(this);
            }
            else {
                Console.WriteLine("This wagon is not connected to this train.");
            }
        }
        public override string ToString() {
            //string s = "";
            //foreach (Chair ch in Sits) {
            //    s = s + "\n" + ch.ToString();
            //}
            return this.GetType().Name + ": number of chairs: " + NumberOfChairs;   // + s;
        }

    }
}
