namespace Parcial02.Entities
{
    public class Question
    {
        public int id { get; set; }
        public string question { get; set; }
      

        public Question()
        {
            
        }

        public Question( string question)
        {
            this.question = question;
        }
    }
}