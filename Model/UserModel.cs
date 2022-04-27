namespace data_integrator_service.Model
{
    public class ListUsers
    {
        
    }
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SchoolId { get; set; }
        public int ParentId { get; set; }
        public string Cpf { get; set; }
        public string Password { get; set; }
        
    }
}
