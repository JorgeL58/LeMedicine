using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMedicine.Models
{
    internal class ConsultationModel
    {
        [MaxLength(20)]
        public int Id { get; set; }
        [MaxLength(20)]
        public DateTime ConsultationDate { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public override string ToString()
        {
            return $"{Id} {ConsultationDate} {Description}";
        }
    }
}
