using FiDeli.Application.Services.Interfaces.RepositoryInterfaces;
using FiDeli.Domain;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Infrastructure.Repos.IMRepos
{
    public class IMParcelLockerRepo
        : IMLocalisableRepository<ParcelLocker>,
        IParcelLockerRepo
    {
        
        public IMParcelLockerRepo()
        {
            List<Locker> lockers = new List<Locker>();

            ParcelLocker parcelLocker = new ParcelLocker
            {
                Id = 1,
                CurrentLocation = new GeoLocation(10, 20),

            };

            ParcelLocker parcelLocker2 = new ParcelLocker
            {
                Id = 2,
                CurrentLocation = new GeoLocation(30, 40),

            };

            ParcelLocker parcelLocker3 = new ParcelLocker
            {
                Id = 3,
                CurrentLocation = new GeoLocation(100, 200),

            };


            for (int i = 0; i < 120; i++)
            {
                lockers.Add(new Locker
                {
                    Size = (Size)(i % 3),
                    Id = i,                    
                }) ;
            }

            for (int i = 0; i < 40; i++)
            {
                lockers[i].ParcelLocker = parcelLocker;
                parcelLocker.Lockers.Add(lockers[i]);

                if (i < 20)
                {
                    lockers[i].CurrentParcel = new Parcel(lockers[i].Size);
                }
            }

            for (int i = 40; i < 80; i++)
            {
                lockers[i].ParcelLocker = parcelLocker2;
                parcelLocker2.Lockers.Add(lockers[i]);

                if (i < 60)
                {
                    lockers[i].CurrentParcel = new Parcel(lockers[i].Size);
                }
            }

            for (int i = 80; i < 120; i++)
            {
                if (i < 100)
                {
                    lockers[i].CurrentParcel = new Parcel(lockers[i].Size);
                }

                lockers[i].ParcelLocker = parcelLocker3;
                parcelLocker3.Lockers.Add(lockers[i]);
            }
        }

    }
}
