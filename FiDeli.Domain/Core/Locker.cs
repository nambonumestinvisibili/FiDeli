using FiDeli.Domain.Core;

namespace FiDeli.Domain
{
    public class Locker : Entity
    {
        public Size Size { get; set; }
        public LockerState LockerState {get;set;}
        public Parcel CurrentParcel { get; set; }

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
    }
}