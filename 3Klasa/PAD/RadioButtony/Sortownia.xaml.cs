using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RadioButtony;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class Sortownia : Window
{
    private int[] Array = null!;
    private const int MaxDisplayLength = 10000;

    public Sortownia()
    {
        InitializeComponent();
    }

    private void GenerateArray_OnClick(object sender, RoutedEventArgs e)
    {
        if (!int.TryParse(SizeOfArray.Text, out int size) ||
            !int.TryParse(MinOfArray.Text, out int min) ||
            !int.TryParse(MaxOfArray.Text, out int max))
        {
            MessageBox.Show("Proszę wypełnić wszystkie pola!", "Brak danych", MessageBoxButton.OK,
                MessageBoxImage.Error);
            OutputBlock.Text = "Brak danych";
            return;
        }

        if (min > max)
        {
            MessageBox.Show("Wartość minimalna nie może być większa od maksymalnej!", "błąd danych",
                MessageBoxButton.OK, MessageBoxImage.Error);
            OutputBlock.Text = "Złe dane";
            return;
        }

        Array = new int[size];
        Random random = new Random();
        for (int i = 0; i < Array.Length; i++) Array[i] = random.Next(min, max);

        OutputBlock.Text = "Udało się wygenerować tablicę!";
    }
    
    // W sortowaniach nie użyłem żadnych sortowań rekurencyjnych, ponieważ przy zbyt dużych tablicach powodują stack overflow.
    // Trzeba by również dodać kod asynchroniczny, aby nie powodowało to "zacinania" się aplikacji
    private void SortArray_OnClick(object sender, RoutedEventArgs e)
    {
        
        if (Array == null)
        {
            MessageBox.Show("Nie wygenerowano tablicy!", "błąd danych",
                MessageBoxButton.OK, MessageBoxImage.Error);
            OutputBlock.Text = "Nie wygenerowano tablicy!";
            return;
        }

        if (!Convert.ToBoolean(SBubble.IsChecked) &&
            !Convert.ToBoolean(SInsert.IsChecked) &&
            !Convert.ToBoolean(SSelection.IsChecked))
        {
            MessageBox.Show("Nie zaznaczono rodzaju sortowania!", "błąd danych",
                MessageBoxButton.OK, MessageBoxImage.Error);
            OutputBlock.Text = "Nie wybrano rodzaju sortowania!";
            return;
        }


        Stopwatch stopwatch = Stopwatch.StartNew();
        stopwatch.Start();
        if (Convert.ToBoolean(SBubble.IsChecked))
        {
            Sort.BubbleSort(Array);
        }
        else if (Convert.ToBoolean(SInsert.IsChecked))
        {
            Sort.InsertionSort(Array);
        }
        else
        {
            Sort.SelectionSort(Array);
        }

        OutputBlock.Text = $"Posortowano tablicę!\nOperacja zajęła {stopwatch.ElapsedMilliseconds} ms.";
        stopwatch.Stop();
    }

    private void ShowArray_OnClick(object sender, RoutedEventArgs e)
    {
        if (Array.Length > MaxDisplayLength)
        {
            MessageBox.Show(
                $"Długość tablicy przekracza maksymalny limit wskazany przez program\n\nLimit wynosi {MaxDisplayLength} elementów.",
                "błąd danych",
                MessageBoxButton.OK, MessageBoxImage.Information);
            OutputBlock.Text = "Tablica jest za długa aby ją wyświetlić!";
            return;
        }

        string buff = "Twoja tablica: ";
        foreach (int i in Array)
        {
            buff += $"{i},";
        }

        OutputBlock.Text = buff;
    }

    private void NumberCheck_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
    {
        // Pomoc z neta
        Regex regex = new Regex("[^0-9]+");
        e.Handled = regex.IsMatch(e.Text);
    }
}