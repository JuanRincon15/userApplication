namespace userApplication.Infrastructure.adapters.input.model.request
{
    public class UserCreateRequest
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string address { get; set; }

        public int idMunicipality { get; set; }

        public UserCreateRequest(string name = "", string phone = "", string address = "", int idMunicipality = 0)
        {
            this.name = name;
            this.phone = phone;
            this.address = address;
            this.idMunicipality = idMunicipality;
        }
    }
}
