namespace userApplication.Domain
{
    public class Department
    {
        public String id {  get; set; }
        public String name { get; set; }
        public List<Municipality> municipalities { get; set; }

        public Department(string id, string name, List<Municipality> municipalities)
        {
            this.id = id;
            this.name = name;
            this.municipalities = municipalities;
        }
    }


}
