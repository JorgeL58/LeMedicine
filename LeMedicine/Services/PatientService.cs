namespace LeMedicine.Services
{
    public class PatientService : IPaciente
    {
        private readonly SQLiteHelper<PatientModel> db;
        public Task<int> Delete(PatientModel patient)
        {
            return Task.FromResult(db.Delete(patient));
        }

        public Task<List<PatientModel>> GetAlls()
        {
            return Task.FromResult(db.GetAllData());
        }

        public Task<PatientModel> GetById(int id)
        {
            return Task.FromResult(db.Get(id));
        }

        public Task<int> Insert(PatientModel patient)
        {
            return Task.FromResult(db.Add(patient));
        }

        public Task<int> Update(PatientModel patient)
        {
            return Task.FromResult(db.Update(patient));
        }
    }
}

