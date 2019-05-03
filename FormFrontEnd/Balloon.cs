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
        //private decimal height; this one is auto
        private decimal diameter;

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                //if(value.ToUpper() == "RED" || value.ToUpper() == "BLUE")
                //{
                    color = value.Trim();
                //}
                //else
                //{
                  //  throw new DataException("Color must be red or blue");
                //}
            }
        }

        private decimal height { get; set; }

        //public string BaloonName { get; set; } just an example of auto properties

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
                if(!string.IsNullOrEmpty(color))
                {
                    if (Color.ToUpper() == "RED")
                    {
                        if (value <= 12)
                        {
                            diameter = value;
                        }
                        else
                        {
                            throw new ConstraintException("Red Baloons Diamaeters cannot be greater 12");
                        }
                    }
                    else if (Color.ToUpper() == "BLUE")
                    {
                        if(value >= 5)
                        {
                            diameter = value;
                        }
                        else
                        {
                            throw new ConstraintException("Blue balloons diameter cannot be less than 5");
                        }
                    }
                }
                else
                {
                    throw new DataException("Color should be set prior");
                }
            }
        }
    }
}
