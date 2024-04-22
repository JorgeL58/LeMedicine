using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMedicine.Models
{
    public class DiagnosticModel
    {
        [MaxLength(20)]
        public int Id { get; set; }
        [MaxLength(20)]
        public DateTime GeneratioDate { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        [MaxLength(500)]
        public string Recommendations { get; set; }
        public override string ToString()
        {
            return $"{Id} {GeneratioDate} {Description} {Recommendations}";
        }
    }
}
