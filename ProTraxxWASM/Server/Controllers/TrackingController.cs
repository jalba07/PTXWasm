// TrackingController.cs
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProTraxx.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProTraxxWASM.Server.Controllers
{
    [ApiController]
    public class TrackingController : ControllerBase
    {
        private static readonly string[] Statuses = new[]
        {
            "Delayed", "Delivered", "Picked Up", "Exception", "On Hold", "En Route", "Rescheduled"
        };

        private static readonly string[] Destinations = new[]
        {
            "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware",
            "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky",
            "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi",
            "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico",
            "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania",
            "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont",
            "Virginia", "Washington", "West Virginia", "Wyoming"
        };

        private readonly IWebHostEnvironment env;
        public TrackingController(IWebHostEnvironment env) => this.env = env;

        [HttpGet]
        [Authorize]
        [Route("api/v1/tracking")]
        public IEnumerable<Tracking> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 50).Select(index => new Tracking
            {
                Date = DateTime.Now.AddDays(-rng.Next(0, 30)),
                Status = Statuses[rng.Next(Statuses.Length)],
                Destination = Destinations[rng.Next(Destinations.Length)],
                User = User.Identity.Name
            });
        }
    }
}