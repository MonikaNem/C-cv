using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class Hopper : IWagon {
        private double loadingCapacity;

        public double LoadingCapacity { get => loadingCapacity; set => loadingCapacity = value; }
        public Hopper(double loadingCapacity) {
            LoadingCapacity = loadingCapacity;
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
        }
        public void DisconnectWagon(Train train) {
            if (train.Wagons.Contains(this)) {
                train.Wagons.Remove(this);
            }
            else {
                Console.WriteLine("This wagon is not connected to this train.");
            }
        }
        public override string ToString() {
            return this.GetType().Name + ": loadingCapacity: " + LoadingCapacity;
        }
    }
}
