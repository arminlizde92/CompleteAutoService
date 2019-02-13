namespace CompleteAutoService.Entities
{
    /// <summary>
    /// service detail class
    /// </summary>
    public class ServiceDetail
    {
        /// <summary>
        /// service detail id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// service detail description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// instance of <see cref="CarPart"/>
        /// </summary>
        public CarPart Part { get; set; }

        /// <summary>
        /// price added to the part price
        /// </summary>
        public decimal AdditionalPrice { get; set; } = 0;

        /// <summary>
        /// service id
        /// </summary>
        public int ServiceId { get; set; }

        /// <summary>
        /// virtual instance of <see cref="Service"/>
        /// </summary>
        public virtual Service Service { get; set; }

        /// <summary>
        /// gets service detail price
        /// </summary>
        public decimal GetServiceDetailPrice() => AdditionalPrice + Part.Price;
    }
}
