namespace data_integrator_service.Model
{
    public class ClassroomModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SchoolId { get; set; }
        public int Period { get; set; } //Criar Enum
        public string Description { get; set; }

    }
}
