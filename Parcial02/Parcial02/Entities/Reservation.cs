using Microsoft.VisualBasic.ApplicationServices;

namespace Parcial02.Entities
{
    public class Reservation
    {
        public int id { get; set; }
        public Username usuario { get; set; }
        public Specialty speciality { get; set; }
        public string dateAndTime { get; set; }

        public Reservation()
        {
            
        }

        public Reservation( Username usuario, Specialty speciality, string dateAndTime)
        {
            this.usuario = usuario;
            this.speciality = speciality;
            this.dateAndTime = dateAndTime;
        }
        
    }
}