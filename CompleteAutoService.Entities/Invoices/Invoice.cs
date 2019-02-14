using System;

namespace CompleteAutoService.Entities.Invoices
{
    /// <summary>
    /// invoice class
    /// </summary>
    public class Invoice
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// a user friendly identification number for invoice
        /// </summary>
        public string IdentificationNumber { get; set; }

        /// <summary>
        /// Customer address, address lines seperated with ";"
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// invoice creation date
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Service Id
        /// </summary>
        public int ServiceId { get; set; }

        /// <summary>
        /// virtual instance of <see cref="Service"/>
        /// </summary>
        public virtual Service Service { get; set; }
    }
}
