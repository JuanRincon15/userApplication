namespace userApplication.Infrastructure.adapters.input.model.request
{
    public class MunicipalityCreateRequest
    {
        public string name { get; set; }
        public int idepartment { get; set; }

        public MunicipalityCreateRequest(string name = "", int idepartment = 0)
        {
            this.name = name;
            this.idepartment = idepartment;
        }
    }
}
