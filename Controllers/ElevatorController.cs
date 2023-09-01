using Microsoft.AspNetCore.Mvc;

namespace elevator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ElevatorController : ControllerBase
    {
        private int elevatorCurrentFloor = 1; // Initial elevator floor
        private List<int> passengerFloors = new List<int>(); // List of passenger-requested floors

        [HttpPost("request")]
        public IActionResult RequestElevator([FromBody] int floor)
        {
            elevatorCurrentFloor = floor;
            return Ok();
        }

        [HttpPost("destination")]
        public IActionResult SetDestination([FromBody] int floor)
        {
            passengerFloors.Add(floor);
            return Ok();
        }

        [HttpGet("passenger-floors")]
        public IActionResult GetPassengerFloors()
        {
            return Ok(new { floors = passengerFloors });
        }

        [HttpGet("next-floor")]
        public IActionResult GetNextFloor()
        {
            if (passengerFloors.Count > 0)
            {
                int nextFloor = passengerFloors[0];
                passengerFloors.RemoveAt(0);
                return Ok(new { floor = nextFloor });
            }
            return Ok(new { floor = elevatorCurrentFloor });
        }
    }
}