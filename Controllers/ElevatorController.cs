using Microsoft.AspNetCore.Mvc;

namespace elevator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ElevatorController : ControllerBase
    {
        private readonly ElevatorState _elevatorState;

        public ElevatorController()
        {
            _elevatorState = ElevatorState.Instance;
        }

        [HttpPost("request")]
        public IActionResult RequestElevator([FromBody] int floor)
        {
            _elevatorState.ElevatorCurrentFloor = floor;
            return Ok();
        }

        [HttpPost("destination")]
        public IActionResult SetDestination([FromBody] int floor)
        {
            _elevatorState.PassengerFloors.Add(floor);
            return Ok();
        }

        [HttpGet("passenger-floors")]
        public IActionResult GetPassengerFloors()
        {
            return Ok(new { floors = _elevatorState.PassengerFloors });
        }

        [HttpGet("next-floor")]
        public IActionResult GetNextFloor()
        {
            if (_elevatorState.PassengerFloors.Count > 0)
            {
                int nextFloor = _elevatorState.PassengerFloors[0];
                _elevatorState.PassengerFloors.RemoveAt(0);
                return Ok(new { floor = nextFloor });
            }
            return Ok(new { floor = _elevatorState.ElevatorCurrentFloor });
        }
    }
}