using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMedicine.Interfaces
{
    public interface IProfessional
    {
        public Task<List<ProfessionalModel>> GetAlls();
        public Task<ProfessionalModel> GetById(int id);
        public Task<int> Insert(ProfessionalModel professional);
        public Task<int> Update(ProfessionalModel professional);
        public Task<int> Delete(ProfessionalModel professional);
    }
}
