namespace userApplication.Domain
{
    public class Country
    {
        public int id { get; set; }
        public string name { get; set; }

        public List<Department> departments { get; set; }

        public Country(int id, string name, List<Department> departments)
        {
            this.id = id;
            this.name = name;
            this.departments = departments;
        }
    }
}
