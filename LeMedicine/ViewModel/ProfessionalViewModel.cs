using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace LeMedicine.ViewModel
{
    public partial class ProfessionalViewModel : ObservableObject
    {
        private readonly IProfessional professionals;
        public ProfessionalViewModel()
        {
            this.professionals = App.Current.Services.GetRequiredService<IProfessional>();
        }

        public ObservableCollection<IProfessional> Professionals { get; set; } = new();
        [RelayCommand]
        public async Task SaveProfessional()
        {
            ProfessionalModel professional = new ProfessionalModel
            {
                FirstName = "Jorge",
                LastName = "Limon",
            };
            await professionals.Insert(professional);
        }
    }
}
