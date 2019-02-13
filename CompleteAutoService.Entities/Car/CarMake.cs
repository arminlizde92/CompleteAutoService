using System.Globalization;

namespace CompleteAutoService.Entities
{
    /// <summary>
    /// car make class
    /// </summary>
    public class CarMake
    {        
        /// <summary>
        /// car make id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// car make name e.g mercedes
        /// </summary>
        public string Name
        {
            get { return Name; }
            set
            {
                // Converts name from any inputed value e.g MERCEDES benz, mercedes BENZ, mErCedes BENZ to Mercedes Benz
                Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value.ToLower());
            }
        }
    }
}