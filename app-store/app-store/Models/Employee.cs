namespace app_store.Models
{
    public class Employee: UserActivtiy
    {
        public int Id { get; set; }
        public string EmpNo { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {MiddleName} {LastName} ";
        public string PhoneNumber { get; set; }
        public string EmaiAddress { get; set; }
        public string Country { get; set; }
        public DateTime DateBirth { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
    }
}
