using userApplication.Infrastructure.adapters.output.persistance.postgreSQL.repositories;

namespace userApplication.Domain
{
    public class Municipality
    {
        public int id { get; set; }
        public string name { get; set; }

        public string idepartment { get; set; }

        public Municipality(int id, string name, string idepartment)
        {
            this.id = id;
            this.name = name;
            this.idepartment = idepartment;
        }
    }
}
