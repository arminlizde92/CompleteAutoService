using System.ComponentModel;

namespace CompleteAutoService.Entities
{
    /// <summary>
    /// abstract car class
    /// </summary>
    public class Car
    {
        /// <summary>
        /// car id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// car make e.g mercedes
        /// </summary>
        public CarMake Make { get; set; }

        /// <summary>
        /// car model e.g w204
        /// </summary>
        public CarModel Model { get; set; }

        /// <summary>
        /// Registration number of the car
        /// </summary>
        public string Registration { get; set; }

        /// <summary>
        /// engine size 2200
        /// </summary>
        [Description("Engine size in CCM")]
        public int Engine { get; set; }

        /// <summary>
        /// year of production
        /// </summary>
        public string Built { get; set; }

        /// <summary>
        /// mileage
        /// </summary>
        public int Mileage { get; set; }

        /// <summary>
        /// true if car is new
        /// </summary>
        public bool New { get; set; }
    }
}