using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPI;


namespace Knap
{
    class Startknap
    {
        private static RPi rpi;
        private static Key key1;
        

        public bool Start()
        {
            rpi = new RPi();
            key1 = new Key(rpi, Key.ID.P1);



        }



     





    }
}
