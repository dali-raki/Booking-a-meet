namespace Agile2TP2.Models
{
    public class BokingModel
    {
        private string v1;
        private int v2;
        private string v3;
        private string v4;

        public string name { get; set; }
        public string room { get; set; }
        public int hour { get; set; }
        public string phoneNumber { get; set; }
        public DateTime date { get; set; }


        public BokingModel(string name, string room, int hour, string phoneNumber, DateTime date)
        {
           this.name = name;
            this.room = room;
            this.hour = hour;
            this.phoneNumber = phoneNumber; 
            this.date = date;
        }


        public BokingModel(string v1, int v2, string v3, string v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }
    }
}
