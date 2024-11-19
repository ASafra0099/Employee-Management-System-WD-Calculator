namespace EmployeeManagement_system.Models
{
    public class PublicHoliday
    {
        public int Id { get; set; }           // Primary key
        public DateTime Date { get; set; }   // Holiday date
        public  string Description { get; set; } //Description about holiday
    }
}
