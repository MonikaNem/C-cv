using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class Program {
        static void Main(string[] args) {
            //VLAK1: 
            //osoby
            Person lenka = new Person("Lenka", "Kozáková");
            Person karel = new Person("Karel", "Novák");

            // vagony
            EconomyWagon ecVagon1 = new EconomyWagon(20);
            BusinessWagon busVagon1 = new BusinessWagon(15, lenka);
            NightWagon nVagon1 = new NightWagon(10, 10);
            Hopper hopper1 = new Hopper(100);

            // lokomotiva a její engine
            Engine engine1 = new Engine("diesel");
            Locomotive loko1 = new Locomotive(karel, engine1);

            // vlak
            Train vlacek1 = new Train(loko1);

            // připojení vagonů
            nVagon1.ConnectWagon(vlacek1);
            busVagon1.ConnectWagon(vlacek1);
            vlacek1.ConnectWagon(ecVagon1);
            vlacek1.ConnectWagon(hopper1);
            Hopper hopper2 = new Hopper(200);
            hopper2.ConnectWagon(vlacek1);

            //VLAK2: 
            Person petr = new Person("Petr", "Němeček");
            Engine engine2 = new Engine("steam");
            Locomotive loco2 = new Locomotive(petr, engine2);
            Train vlacek2 = new Train(loco2);
            BusinessWagon busVagon2 = new BusinessWagon(15, lenka);
            vlacek2.ConnectWagon(busVagon2);
            vlacek2.ConnectWagon(new Hopper(100));
            vlacek2.ConnectWagon(new Hopper(100));
            vlacek2.ConnectWagon(new Hopper(100));
            vlacek2.ConnectWagon(new Hopper(100));
            vlacek2.ConnectWagon(new Hopper(100));  // tenhle už nejde připojit - vypíše hlášku

            //REZERVACE SEDADEL: 
            // vagon se naplní daným počtem sedadel v konstruktoru personal vagonu
            vlacek1.ReserveChair(3, 1);
            vlacek1.ReserveChair(1, 1);
            vlacek1.ReserveChair(1, 10);
            vlacek1.ReserveChair(3, 3);
            vlacek1.ReserveChair(3, 4);
            vlacek1.ReserveChair(3, 8);
            vlacek1.ReserveChair(4, 1); // hopper, nejde rezervovat
            vlacek1.ReserveChair(3, 1); // už rezervováno, nejde rezervovat
            vlacek1.ListReservedChairs();
            //vlacek2.ListReservedChairs();

            //INFO O OBOU VLACÍCH: 
            Console.WriteLine(vlacek1.ToString());
            Console.WriteLine(vlacek2.ToString());
        }
    }
}
