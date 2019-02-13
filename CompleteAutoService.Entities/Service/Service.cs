using System.Collections.Generic;
using System.Linq;

namespace CompleteAutoService.Entities
{
    /// <summary>
    /// service class
    /// </summary>
    public class Service
    {
        /// <summary>
        /// service id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// instance of a <see cref="ServiceType"/>
        /// </summary>
        ServiceType Type { get; set; }

        /// <summary>
        /// Service description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// virtual ienumerable for service details
        /// </summary>
        public virtual IEnumerable<ServiceDetail> ServiceDetails { get; private set; }

        /// <summary>
        /// Price entered by the user
        /// </summary>
        public decimal FixedPrice { get; set; }

        /// <summary>
        /// gets price from service details
        /// </summary>
        /// <returns></returns>
        public decimal GetServiceDetailsPrice()
        {
            return ServiceDetails.Sum(d => d.GetServiceDetailPrice());
        }
    }
}