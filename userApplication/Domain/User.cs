namespace userApplication.Domain
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string nameMunicipality { get; set; }

        public User()
        {
        }

        public User(int id = 0, string name="", string phone = "", string address = "", string nameMunicipality = "")
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.address = address;
            this.nameMunicipality = nameMunicipality;
        }


    }
}
