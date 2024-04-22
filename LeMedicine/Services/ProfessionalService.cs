namespace LeMedicine.Services
{
    public class ProfessionalService : IProfessional
    {
        private readonly SQLiteHelper<ProfessionalModel> db;
        public Task<int> Delete(ProfessionalModel professional)
        {
            return Task.FromResult(db.Delete(professional));
        }

        public Task<List<ProfessionalModel>> GetAlls()
        {
            return Task.FromResult(db.GetAllData());
        }

        public Task<ProfessionalModel> GetById(int id)
        {
            return Task.FromResult(db.Get(id));
        }

        public Task<int> Insert(ProfessionalModel professional)
        {
            return Task.FromResult(db.Add(professional));
        }

        public Task<int> Update(ProfessionalModel professional)
        {
            return Task.FromResult(db.Update(professional));
        }
    }
}
