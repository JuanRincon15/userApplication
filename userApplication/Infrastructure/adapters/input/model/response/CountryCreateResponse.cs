namespace userApplication.Infrastructure.adapters.input.model.response
{
    public class CountryCreateResponse
    {
        public int id { get; set; }
        public string name { get; set; }

        public CountryCreateResponse(int id = 0, string name = "")
        {
            this.id = id;
            this.name = name;
        }
    }
}
