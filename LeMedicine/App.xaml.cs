using LeMedicine.ViewModel;

namespace LeMedicine
{
    public partial class App : Application
    {
        public new static App Current => (App)Application.Current;
        public IServiceProvider Services { get; }
        public App()
        {
            var services = new ServiceCollection();

            Services = ConfigureServices(services);

            InitializeComponent();

            MainPage = new AppShell();
        }


        //Creando el colector de dependencias
        private static IServiceProvider ConfigureServices(ServiceCollection services)
        {
            //Servicios
            services.AddSingleton<IPaciente, PatientService>();
            services.AddSingleton<IProfessional, ProfessionalService>();
            

            //ViewModels
            services.AddTransient<PatientViewModel>();
            services.AddTransient<ProfessionalViewModel>();

            //views
            services.AddSingleton<PatientsListPage>();
            services.AddSingleton<ProfessionalsListPage>();
            return services.BuildServiceProvider();
        }
    }
}
