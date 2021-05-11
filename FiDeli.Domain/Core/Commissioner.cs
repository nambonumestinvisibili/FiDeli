using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Domain
{
    public class Commissioner : Person
    {
        public List<Commission> Commisions { get; set; }
        public void CreateCommision() //params...
        {
            //commission factory
        }       

    }
}
