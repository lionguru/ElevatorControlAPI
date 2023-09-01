namespace elevator.Controllers
{
    public class ElevatorState
    {
        private static ElevatorState _instance;
        private static readonly object _lock = new object();

        private ElevatorState()
        {
            PassengerFloors = new List<int>();
            ElevatorCurrentFloor = 1;
        }

        public static ElevatorState Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ElevatorState();
                    }
                    return _instance;
                }
            }
        }

        public int ElevatorCurrentFloor { get; set; }
        public List<int> PassengerFloors { get; private set; }
    }

}
