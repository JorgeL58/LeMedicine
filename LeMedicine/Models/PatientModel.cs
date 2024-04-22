namespace LeMedicine.Models
{
    [Table("Patients")]
    public class PatientModel
    {
        [MaxLength(20)]
        public int Id { get; set; }
        [MaxLength(20)]
        public string FirstName { get; set; }
        [MaxLength(20)]
        public string LastName { get; set; }
        [MaxLength(10)]
        public string Birthday { get; set; }
        [MaxLength(10)]
        public string EmergencyContact { get; set; }

        public override string ToString()
        {
            return $"{Id} {FirstName} {LastName} {Birthday} {EmergencyContact}";
        }
    }
}
