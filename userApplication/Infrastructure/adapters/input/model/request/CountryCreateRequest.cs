namespace userApplication.Infrastructure.adapters.input.model.request
{
    public class CountryCreateRequest
    {
        public string name { get; set; }

        public CountryCreateRequest(string name = "")
        {
            this.name = name;
        }
    }
}
