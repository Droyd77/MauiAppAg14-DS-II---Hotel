namespace MauiAppAg13_DS_II___Hotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new views.ContratacaoHospedagem ());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window =base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;// retorno da mesma instancia configurada
        }
    }
}
