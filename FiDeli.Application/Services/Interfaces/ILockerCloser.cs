using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiDeli.Domain;

namespace FiDeli.Application.Services.Interfaces

{
    public interface ILockerCloser
    {
        public void LockPackage(Parcel package, ParcelLocker packageLocker, Person lockerer);
        public void CloseEmptyLocker(ParcelLocker parcelLocker);

    }
}
