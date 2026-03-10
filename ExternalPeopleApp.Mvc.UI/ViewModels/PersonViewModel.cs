namespace ExternalPeopleApp.Mvc.UI.ViewModels
{
    public class PersonViewModel
    {
        public long Id { get; set; }
        public string Firstname { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public long DepartmentId { get; set; }
        public long LocationId { get; set; }
    }
}
