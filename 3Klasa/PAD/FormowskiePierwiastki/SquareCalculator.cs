namespace FormowskiePierwiastki;

public partial class SquareCalculator : Form
{
    public SquareCalculator()
    {
        InitializeComponent();
    }

    private void CalculateButton_Click(object sender, EventArgs e)
    {
        try
        {
            int iterations = PrecisionTrackBar.Value;
            double number = double.Parse(NumberTextBox.Text);
            
            SqrtBrain sqrtBrain = SqrtBrain.GetInstance();
            
            double resultMathLib = sqrtBrain.CalculateSqrtMathLib(number);
            double resultAlgo = sqrtBrain.CalculateSqrtAlgo(number, iterations);
            
            MessageBox.Show($"Pierwiastek z {number}:\n" +
                            $"Math.Sqrt: {resultMathLib}\n" +
                            $"Algorytm: {resultAlgo}", "Wynik",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception)
        {
            MessageBox.Show("Niepoprawne dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}