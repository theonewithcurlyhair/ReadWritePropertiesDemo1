using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormFrontEnd
{
    public class Balloon
    {
        private string color;
        private decimal height;
        private decimal diameter;

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                if(value.ToUpper() == "RED" || value.ToUpper() == "BLUE")
                {
                    color = value;
                }
                else
                {
                    throw new DataException("Color must be red or blue");
                }
            }
        }
        public decimal Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public decimal Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                diameter = value;
            }
        }
    }
}
