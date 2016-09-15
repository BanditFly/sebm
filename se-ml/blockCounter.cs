using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace se_ml
{
    class blockCounter
    {

        public int blockcount;
       

        public void countBlocks(string[] blueprint)
        {
            for (int i = 0; i < blueprint.Length; i++)
            {
                if(blueprint[i].Contains("<MyObjectBuilder_CubeBlock xsi:type=")) { blockcount++; }

            }
        }

        public string getGridsize(string[] blueprint)
        {

            for (int i = 0; i < blueprint.Length; i++)
            {
                if (blueprint[i].Contains("<GridSizeEnum>Large</GridSizeEnum>")) { return("Gridsize: Large"); }
                if (blueprint[i].Contains("<GridSizeEnum>Small</GridSizeEnum>")) { return("Gridsize: Small"); }
                if (blueprint[i].Contains("<GridSizeEnum>Station</GridSizeEnum>")) { return ("Gridsize: Station"); }
            }

            return "";
        }

        public void resetCounter()
        {

            blockcount = 0;
        }

    }
}
