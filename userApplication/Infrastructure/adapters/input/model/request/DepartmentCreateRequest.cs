namespace userApplication.Infrastructure.adapters.input.model.request
{
    public class DepartmentCreateRequest
    {
        public string name { get; set; }

        public int country { get; set; }

        public DepartmentCreateRequest(string name = "", int country = 0)
        {
            this.name = name;
            this.country = country;
        }
    }
}
