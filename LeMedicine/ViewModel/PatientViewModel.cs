using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace LeMedicine.ViewModel
{
    public partial class PatientViewModel : ObservableObject
    {
        private readonly IPaciente patients;
        public PatientViewModel()
        {
            this.patients = App.Current.Services.GetRequiredService<IPaciente>();
        }

        public ObservableCollection<PatientViewModel> Patients { get; set; } = new();
        [RelayCommand]
        public async Task SavePatient()
        {
            PatientModel patient = new PatientModel
            {
                FirstName = "Emanuel",
                LastName = "Rendón",
            };
            await patients.Insert(patient);
        }
    }
}
