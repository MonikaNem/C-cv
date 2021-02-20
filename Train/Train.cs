using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class Train {
        private Locomotive locomotive;
        private List<IWagon> wagons;

        internal Locomotive Locomotive { get => locomotive; set => locomotive = value; }
        internal List<IWagon> Wagons { get => wagons; set => wagons = value; }
        
        public Train() {
        }
        public Train(Locomotive locomotive) {
            Locomotive = locomotive;
            Wagons = new List<IWagon>();
        }
        public Train(Locomotive locomotive, List<IWagon> wagons) : this(locomotive) {
            Wagons = wagons;
        }
        public void ConnectWagon(IWagon wagonToConnect) {
            wagonToConnect.ConnectWagon(this);      // odkaz na metodu vagonu
        }
        public void DisconnectWagon(IWagon wagonToDisconnect) {
            if (Wagons.Contains(wagonToDisconnect)) {
                wagonToDisconnect.DisconnectWagon(this);    // odkaz na metodu vagonu
            }
        }
        public void ReserveChair(int wagonNumber, int chairNumber) {
            if (wagonNumber <= this.Wagons.Count) {      //existuje vagon (je ve vlaku tolik vagonů?)   
                if (this.Wagons[wagonNumber - 1] is PersonalWagon) {
                    if (chairNumber <= ((PersonalWagon)this.Wagons[wagonNumber - 1]).Sits.Count) {    //existuje sedadlo (je tam tolik sedadel?)
                        if (((PersonalWagon)this.Wagons[wagonNumber - 1]).Sits[chairNumber - 1].Reserved == false) {
                            ((PersonalWagon)this.Wagons[wagonNumber - 1]).Sits[chairNumber - 1].Reserved = true;
                            Console.WriteLine("Seat has been successfully reserved.");
                        }
                        else {
                            Console.WriteLine("This seat is already reserved.");
                        }
                    }
                    else {
                        Console.WriteLine("Selected wagon does not contain this chair number.");
                    }
                }
                else {
                    Console.WriteLine("You can´t reserve a seat in this wagon - it is not a personal wagon.");
                }
            }
            else {
                Console.WriteLine("This wagon number does not exist in this train.");
            }
        }
        public void ListReservedChairs() {
            Console.WriteLine("List of reserved chairs: ");
            for (int i = 0; i < Wagons.Count; i++) {
                if (this.Wagons[i] is PersonalWagon) {
                    int count = 0;
                    Console.WriteLine("Wagon no." + (i + 1) + ": " + this.Wagons[i].GetType().Name + ": ");
                    for (int j = 0; j < ((PersonalWagon)Wagons[i]).Sits.Count; j++) {
                        if (((PersonalWagon)this.Wagons[i]).Sits[j].Reserved == true) {
                            Console.WriteLine("Chair no." + ((PersonalWagon)Wagons[i]).Sits[j].Number + "\treserved");
                            count++;
                        }
                    }
                    if (count == 0) {
                        Console.WriteLine("- no reserved chairs");
                    }
                }
            }
        }
        public override string ToString() {
            string s = "";
            int i = 1;
            foreach (IWagon w in Wagons) {
                s = s + i + ".wagon: " + w.ToString() + "\n";
                i++;
            }
            return "Locomotive: " + Locomotive.ToString() + "\nWagons: \n" + s;
        }
    }
}
