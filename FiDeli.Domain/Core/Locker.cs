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

    }
}