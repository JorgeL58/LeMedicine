namespace LeMedicine.Interfaces
{
    public interface IPaciente
    {
        public Task<List<PatientModel>> GetAlls();
        public Task<PatientModel> GetById(int id);
        public Task<int> Insert(PatientModel patient);
        public Task<int> Update(PatientModel patient);
        public Task<int> Delete(PatientModel patient);
    }
}
