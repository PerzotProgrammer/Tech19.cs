using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Desktopowa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private int previousDistanceInput = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBoxDistance_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            double meterNormalized = 1;
            if (FromDistanceMeter.IsSelected) meterNormalized = previousDistanceInput;
            else if (FromDistanceKilometer.IsSelected) meterNormalized = previousDistanceInput * 1000;
            else if (FromDistanceCentimeter.IsSelected) meterNormalized = previousDistanceInput * 0.01;
            else if (FromDistanceInch.IsSelected) meterNormalized = previousDistanceInput * 2.54;
            else if (FromDistanceFoot.IsSelected) meterNormalized = previousDistanceInput * 2.54 * 12;
            else if (FromDistanceMile.IsSelected) meterNormalized = previousDistanceInput * 2.54 * 12 * 5280;

            //if (ToDistanceMeter.IsSelected) meterNormalized = meterNormalized; // Można pominąć
            if (ToDistanceKilometer.IsSelected) meterNormalized = meterNormalized / 1000;
            else if (ToDistanceCentimeter.IsSelected) meterNormalized = meterNormalized / 0.01;
            else if (ToDistanceInch.IsSelected) meterNormalized = meterNormalized / 2.54;
            else if (ToDistanceFoot.IsSelected) meterNormalized = meterNormalized / 2.54 / 12;
            else if (ToDistanceMile.IsSelected) meterNormalized = meterNormalized / 2.54 / 12 / 5280;

            DistanceOutput.Text = $"{double.Round(meterNormalized, 4)}";
        }


        private void DistanceInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!int.TryParse(DistanceInput.Text, out int validInt))
            {
                MessageBox.Show("Nieporawne dane!");
                DistanceInput.Text = previousDistanceInput.ToString();
                return;
            }
            previousDistanceInput = validInt;
        }
    }
}