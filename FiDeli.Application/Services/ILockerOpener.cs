using FiDeli.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Application
{
    public interface ILockerOpener
    {
        void OpenLocker(Parcel parcel, ParcelLocker parcelLocker, Person lockerer);

    }
}
