using System;

namespace data_integrator_service.Model
{
    public class SchoolModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cnpj { get; set; }
        public string Address { get; set; }
        public DateTime Created_At { get; set; }
    }
}
