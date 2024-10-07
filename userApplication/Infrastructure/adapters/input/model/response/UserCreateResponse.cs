namespace userApplication.Infrastructure.adapters.input.model.response
{
    public class UserCreateResponse
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
 

        public UserCreateResponse(int id = 0, string name = "", string phone = "", string address = "")
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.address = address;
        }
    }
}
