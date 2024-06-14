
using Desafio4.Models;

namespace Desafio4
{
    public partial class MainPage : ContentPage
    {
        public List<FrutaInformacion> ManzanaInfo { get; set; }
        public MainPage()
        {
            InitializeComponent();
            ManzanaInfo = new List<FrutaInformacion>()
            {
                new FrutaInformacion
                {
                    Micronutrientes="Vitamina C",
                    Porcentaje=8
                },
                new FrutaInformacion
                {
                    Micronutrientes="Vitamina A",
                    Porcentaje=1
                },
                new FrutaInformacion
                {
                    Micronutrientes="Calcio",
                    Porcentaje=1
                },
                new FrutaInformacion
                {
                    Micronutrientes="Magnesio",
                    Porcentaje=1
                },
                new FrutaInformacion
                {
                    Micronutrientes="potasio",
                    Porcentaje=3
                }
            };
            this.BindingContext = this;
        }

       
    }

}
