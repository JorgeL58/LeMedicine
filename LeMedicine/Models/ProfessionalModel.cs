namespace LeMedicine.Models
{
    [Table("Professionals")]
    public class ProfessionalModel
    {
        [MaxLength(20)]
        public int Id { get; set; }
        [MaxLength(20)]
        public string FirstName { get; set; }
        [MaxLength(20)]
        public string LastName { get; set; }
        [MaxLength(20)]
        public string Specialty { get; set; }
        public override string ToString()
        {
            return $"{Id} {FirstName} {LastName} {Specialty}";
        }
    }
}
