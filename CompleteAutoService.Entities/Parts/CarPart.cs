namespace CompleteAutoService.Entities
{
    /// <summary>
    /// car part class
    /// </summary>
    public class CarPart
    {
        /// <summary>
        /// car part id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// car part name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// car part description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// true if part new
        /// </summary>
        public bool IsNew { get; set; }

        /// <summary>
        /// part price
        /// </summary>
        public decimal Price { get; set; } = 0;
    }
}
