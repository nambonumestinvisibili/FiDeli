using FiDeli.Domain.Core;

namespace FiDeli.Domain
{
    public class Locker : Entity
    {
        public Size Size { get; set; }
        public LockerState LockerState {get;set;}
        public Parcel CurrentParcel { get; set; }
        public ParcelLocker ParcelLocker { get; set; }

        public void Open()
        {
            LockerState = LockerState.OPEN;
        }

        public void Close()
        {
            LockerState = LockerState.CLOSED;
        }

        public bool CanBeOpenedBy<T>(ParcelCode code) where T : Person
        {
            if (CurrentParcel == null)
            {
                return true;
            }
            else
            {
                return CurrentParcel.CanBeOpenedBy<T>(code);
            }
        }

        public bool ContainsParcelWithCode(ParcelCode code)
        {
            return CurrentParcel.IsAccessibleByCode(code);
        }

        public void EmptyLocker()
        {
            CurrentParcel = null;
        }

        public void LoadLocker(Parcel parcel)
        {
            if (parcel.Size == Size)
            {
                CurrentParcel = parcel;

            }
            else
            {
                throw new System.Exception("Parcel cannot fit into the locker");
            }
        }

        public bool EnsureContains()
        {
            return CurrentParcel != null;
        }

        public bool EnsureEmpty()
        {
            return CurrentParcel == null;
        }


    }
}