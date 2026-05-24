using System;
using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace MauiAppHotel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Configurando limites iniciais dos DatePickers
            dtp_checkin.MinimumDate = DateTime.Now;
            dtp_checkout.MinimumDate = DateTime.Now.AddDays(1);

            // Populando o Picker de Suítes de forma simples
            pck_suite.ItemsSource = new List<string>
            {
                "Suíte Econômica - R$ 150,00/dia",
                "Suíte Executiva - R$ 250,00/dia",
                "Suíte Premium Luxury - R$ 500,00/dia"
            };
        }

        private async void OnAvancarClicked(object sender, EventArgs e)
        {
            if (pck_suite.SelectedIndex == -1)
            {
                await DisplayAlert("Erro", "Por favor, selecione uma suíte.", "OK");
                return;
            }

            // Lógica para instanciar e passar dados via Hospedagem (Exemplo de uso futuro do BindingContext)
            await DisplayAlert("Sucesso", "Dados registrados temporariamente!", "OK");
        }

        private async void OnSobreClicked(object sender, EventArgs e)
        {
            // Navega para a nova tela adicionada na Etapa 2
            await Navigation.PushAsync(new SobrePage());
        }
    }
}