namespace Parcial02.Entities
{
    public class Specialty
    {
        public int id { get; set; }
        public string specialitys { get; set; }

        public Specialty()
        {
            
        }

        public Specialty( string specialitys)
        {
            this.specialitys = specialitys;
        }
        
    }
}