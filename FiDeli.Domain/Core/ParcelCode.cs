using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Domain.Core
{
    public class ParcelCode
    {
        public string Code { get; }

        public ParcelCode()
        {
            Code = Guid.NewGuid().ToString().Substring(0, 7);
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(ParcelCode)) return false;
            else
            {
                return ((ParcelCode)obj).Code == Code;
            }
            
        }
    }
}
