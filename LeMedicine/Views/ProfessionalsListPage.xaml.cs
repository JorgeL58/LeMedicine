using LeMedicine.ViewModel;

namespace LeMedicine.Views;

public partial class ProfessionalsListPage : ContentPage
{
	public ProfessionalsListPage()
	{
        BindingContext = App.Current.Services.GetRequiredService<ProfessionalViewModel>();
        InitializeComponent();
	}
}