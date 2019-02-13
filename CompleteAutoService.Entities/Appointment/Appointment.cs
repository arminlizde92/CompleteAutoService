using System;

namespace CompleteAutoService.Entities
{
    public class Appointment
    {
        /// <summary>
        /// Appointment id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// appointment date
        /// </summary>
        public DateTime AppointmentDate { get; set; }

        /// <summary>
        /// email of person which is asking for an appointment
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Mobile number of person which is asking for an appointment
        /// </summary>
        public string MobilePhone { get; set; }

        /// <summary>
        /// Telephone of person which is asking for an appointment
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// <see cref="Car"/> car
        /// </summary>
        public Car Car { get; set; }

        /// <summary>
        /// <see cref="Service" details/>
        /// </summary>
        public Service Service { get; set; }

        /// <summary>
        /// if there are changes in the appoinment e.g. date this is set to true
        /// </summary>
        public bool Changes { get; set; } = false;

        /// <summary>
        /// true if appointment is approved
        /// </summary>
        public bool Approved { get; set; } = false;

        /// <summary>
        /// true if appointment is finished
        /// </summary>
        public bool Finished { get; set; } = false;

        /// <summary>
        /// status tells if the appointment is still active, 
        /// combination with finished and approved can give more infos
        /// </summary>
        public bool Status { get; set; } = true;
    }
}
