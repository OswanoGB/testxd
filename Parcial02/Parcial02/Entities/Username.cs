using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Parcial02.Entities
{
    public class Username
    {
        
        public string idCard  { get; set; }
        
        public string nombre { get; set; }
        public string password { get; set; }
        public Question question { get; set; }
        public string answer { get; set; }

        public Username()
        {
            
        }

        public Username(string idCard, string nombre, string password, Question question, string answer)
        {
            this.idCard = idCard;
            this.nombre = nombre;
            this.password = password;
            this.question = question;
            this.answer = answer;
        }
        
    }
}