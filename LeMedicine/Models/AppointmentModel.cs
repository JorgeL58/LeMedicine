using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMedicine.Models
{
    public class AppointmentModel
    {
        [MaxLength(20)]
        public int Id { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        [MaxLength (10)]
        public DateTime AppointmentDate { get; set; }
        [MaxLength (10)]
        public DateTime AppointmentTime { get; set; }
        public override string ToString()
        {
            return $"{Id} {Description} {AppointmentDate} {AppointmentTime}";
        }
    }
}
