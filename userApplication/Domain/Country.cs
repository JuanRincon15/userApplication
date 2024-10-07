namespace userApplication.Domain
{
    public class Country
    {
        public int id { get; set; }
        public string name { get; set; }

        public List<Department> departments { get; set; }

        public Country(int id = 0, string name = "", List<Department> departments = null)
        {
            this.id = id;
            this.name = name;
            this.departments = departments;
        }
    }
}
