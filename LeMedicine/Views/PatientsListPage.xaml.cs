using LeMedicine.ViewModel;

namespace LeMedicine.Views;

public partial class PatientsListPage : ContentPage
{
	public PatientsListPage()
	{
        BindingContext = App.Current.Services.GetRequiredService<PatientViewModel>();
        InitializeComponent();
	}
}