using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display
{
    public class Display
    {
        private string socSecNb;
        private DateTime dateTime;


        public void visInfo { get; set; }


        public void display(string socSecNb, DateTime dateTime)
        {
            this.socSecNb = socSecNb;
            this.dateTime = dateTime;
        }

        
        


    }
}
