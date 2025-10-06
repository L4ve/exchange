using Microsoft.Extensions.Logging.Abstractions;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            if (double.TryParse(entry.Text, out double inputValue))
            {
                double result = inputValue * selectedMultiplier;
                entry2.Text = result.ToString("F2");
            }
            else
            {
                entry2.Text = "zzz";
            }
        }


        double selectedMultiplier = 1;

        private void OnCurrencyChanged(object sender, CheckedChangedEventArgs e)
        {
            if (!e.Value) return;

            if (sender == usdRadio && double.TryParse(usdEntry.Text, out double usd))
                selectedMultiplier = usd;
            else if (sender == eurRadio && double.TryParse(eurEntry.Text, out double eur))
                selectedMultiplier = eur;
            else if (sender == wongRadio && double.TryParse(wongEntry.Text, out double wong))
                selectedMultiplier = wong;
            else if (sender == idkRadio && double.TryParse(idkEntry.Text, out double idk))
                selectedMultiplier = idk;
        }

    }
}
