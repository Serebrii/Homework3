using System;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnConfirmButtonClicked(object sender, EventArgs e)
        {
            if (int.TryParse(NumberEntry.Text, out int number))
            {
                ResultLabel.Text = $"Унели сте број {number}";
            }
            else
            {
                ResultLabel.Text = "Унесите исправан цео број.";
            }
        }
    }
}
