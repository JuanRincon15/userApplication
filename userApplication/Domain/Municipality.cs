namespace userApplication.Domain
{
    public class Municipality
    {
        public string id { get; set; }
        public string name { get; set; }

        public Municipality(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
