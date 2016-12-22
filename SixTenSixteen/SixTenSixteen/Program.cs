using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixTenSixteen
{
    class Program
    {
        protected static void Main(string[] args)
        {
            // Serializing and deserializing data from the home/computer objects
            SerializeData sdata = new SerializeData("testBinaryfile.txt");
            HomeObject home = new HomeObject();
            home.setHomeType(HomeObject.TYPE.CONDO);
            home.setYear(2000);

            ComputerObject co = new ComputerObject();
            co.setType(ComputerObject.PC_TYPE.LINUX);
            co.SetCost(0.0);

            sdata.SerializeObject(home);
            sdata.SerializeObject(co);

            sdata.closeStream();

            sdata.DeserializeObjects();
            sdata.closeStream();

        }
    }
}
