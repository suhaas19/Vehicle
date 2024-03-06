using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Model
    {
        public string CarName;
        public string ModelYear;

        public Model(string cName, string mYear)
        {

            CarName = cName;
            this.ModelYear = mYear;
        }
        public string getName()
        {
            return CarName + " " + ModelYear;
        }
    }
}
