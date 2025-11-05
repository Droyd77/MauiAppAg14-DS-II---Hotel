using MauiAppAg13_DS_II___Hotel.Models;

namespace MauiAppAg13_DS_II___Hotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao= "Suite Super luxo",
                ValorDiariaAdulto= 100.00,
                valorDiariaCrianca=80.00
            },
            new Quarto()
            {
                Descricao="Suite Luxo",
                ValorDiariaAdulto=80.00,
                valorDiariaCrianca=60.00
            },
            new Quarto()
            {
                Descricao="Suite Single",
                ValorDiariaAdulto=60.00,
                valorDiariaCrianca=40.00
                
            },
             new Quarto()
            {
                Descricao="Suite Crise",
                ValorDiariaAdulto=40.00,
                valorDiariaCrianca=20.00

            }

        };


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
