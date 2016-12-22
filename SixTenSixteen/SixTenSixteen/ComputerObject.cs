using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixTenSixteen
{
    [Serializable]
    class ComputerObject
    {
        public enum PC_TYPE { WINDOWS, LINUX, MAC };
        PC_TYPE ptype;

        double cost = 0;
        public ComputerObject()
        {

        }

        public void SetCost(double cost)
        {
            this.cost = cost;
        }

        public void setType(PC_TYPE type)
        {
            ptype = type;
        }

        public PC_TYPE getType()
        {
            return ptype;
        }

        public String printContent()
        {
            String msg = "PC Type: " + ptype + " Cost: " + cost;
            return msg;
        }


    }
}
