namespace userApplication.Domain
{
    public class Department
    {
        public int id {  get; set; }
        public string name { get; set; }
        
        public int country {  get; set; }
        public List<Municipality> municipalities { get; set; }

        public Department(int id = 0, string name= "", int country = -1, List<Municipality> municipalities = null)
        {
            this.id = id;
            this.name = name;
            this.country = country;
            this.municipalities = municipalities;
        }
    }


}
