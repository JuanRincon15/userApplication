using userApplication.Infrastructure.adapters.output.persistance.postgreSQL.repositories;

namespace userApplication.Domain
{
    public class Municipality
    {
        public int id { get; set; }
        public string name { get; set; }

        public int idepartment { get; set; }

        public Municipality(int id= 0, string name= "", int idepartment = 0)
        {
            this.id = id;
            this.name = name;
            this.idepartment = idepartment;
        }
    }
}
