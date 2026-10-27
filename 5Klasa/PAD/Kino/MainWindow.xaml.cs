using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace Kino;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly IList<Tuple<string, Uri>> _comboBoxTitles = new List<Tuple<string, Uri>>();
    private readonly IList<Seat> _seats = new List<Seat>();

    private const int TICKET_BASE_PRICE = 30;

    private double _totalPrice;

    public MainWindow()
    {
        InitializeComponent();

        _comboBoxTitles.Add(new("Zemsta kompilatora", new Uri("Content/Kompilator.png", UriKind.Relative)));
        _comboBoxTitles.Add(new("Null pointer exception", new Uri("Content/NullPointer.png", UriKind.Relative)));
        _comboBoxTitles.Add(new("Ostatni commit", new Uri("Content/Commit.png", UriKind.Relative)));

        foreach (Tuple<string, Uri> comboBoxTitle in _comboBoxTitles)
            CBSelectedMovie.Items.Add(comboBoxTitle.Item1);

        CBSelectedMovie.SelectedIndex = 0;

        ImgPoster.Source = new BitmapImage(_comboBoxTitles[0].Item2);

        BuildCinemaHall(10, 20);

        CBSelectedMovie.SelectionChanged += CBSelectedMovieOnSelectionChanged;
    }

    private void CBSelectedMovieOnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        ImgPoster.Source = new BitmapImage(_comboBoxTitles[CBSelectedMovie.SelectedIndex].Item2);
    }

    private void RectangleOnMouseDown(object sender, MouseButtonEventArgs e) => CalculatePrice();

    private void BuildCinemaHall(int rows, int columns)
    {
        GCinemaHallMap.Children.Clear();
        GCinemaHallMap.RowDefinitions.Clear();
        GCinemaHallMap.ColumnDefinitions.Clear();
        _seats.Clear();

        for (int i = 0; i < rows; i++)
        {
            GCinemaHallMap.RowDefinitions.Add(new RowDefinition
            {
                Height = new GridLength(1, GridUnitType.Star)
            });
        }

        for (int j = 0; j < columns; j++)
        {
            GCinemaHallMap.ColumnDefinitions.Add(new ColumnDefinition
            {
                Width = new GridLength(1, GridUnitType.Star)
            });
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Seat seat = new Seat(Seat.Occupation.Empty, i, j);

                _seats.Add(seat);
                GCinemaHallMap.Children.Add(seat.Rectangle);

                seat.Rectangle.MouseDown += RectangleOnMouseDown;
            }
        }

        _seats[new Random().Next(_seats.Count)]
            .SetOccupation(Seat.Occupation.Occupied);
    }

    private void CalculatePrice()
    {
        {
            int selectedCount = _seats.Count(seat =>
                seat.CurrentOccupation == Seat.Occupation.Selected);

            TBlkSelectedCount.Text = $"Wybrano: {selectedCount}";

            if (selectedCount == 0)
            {
                TBlkPrice.Text = "Do zapłaty: -- zł";
                TBlkDiscount.Text = "Rabat: -- %";
                return;
            }

            Discount.Type discount = selectedCount switch
            {
                1 => Discount.Type.None,
                2 => Discount.Type.Medium,
                _ => Discount.Type.Big
            };

            double multiplier = discount.GetMultiplier();
            double discountPercent = (1 - multiplier) * 100;
            _totalPrice = TICKET_BASE_PRICE * selectedCount * multiplier;

            TBlkDiscount.Text = $"Rabat: {discountPercent:0} %";
            TBlkPrice.Text = $"Do zapłaty: {_totalPrice:0.00} zł";
        }
    }


    private void OnReservationButtonOnClick(object sender, RoutedEventArgs e)
    {
        if (RBHour1200.IsChecked != true && RBHour1800.IsChecked != true && RBHour2100.IsChecked != true)
        {
            MessageBox.Show("Wybierz godzinę seansu!", "Niepoprawne dane", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        if (_seats.Count(seat => seat.CurrentOccupation == Seat.Occupation.Selected) == 0)
        {
            MessageBox.Show("Wybierz co najmniej jedno miejsce!", "Niepoprawne dane", MessageBoxButton.OK,
                MessageBoxImage.Error);
            return;
        }


        if (TBName.Text.Trim() == string.Empty || TBEmail.Text.Trim() == string.Empty)
        {
            MessageBox.Show("Dane nie mogą być puste!", "Niepoprawne dane", MessageBoxButton.OK,
                MessageBoxImage.Error);
            return;
        }

        string hour = string.Empty;
        if (RBHour1200.IsChecked == true) hour = "12:00";
        if (RBHour1800.IsChecked == true) hour = "18:00";
        if (RBHour2100.IsChecked == true) hour = "21:00";

        string selectedSeats = string.Join(", ",
            _seats
                .Select((seat, index) => new { seat, number = index + 1 })
                .Where(x => x.seat.CurrentOccupation == Seat.Occupation.Selected)
                .Select(x => x.number));

        MessageBox.Show($"Klient: {TBName.Text}\n" +
                        $"Film: {CBSelectedMovie.Text}\n" +
                        $"Godzina: {hour}\n" +
                        $"Miejsca: {selectedSeats}\n" +
                        $"Do zapłaty: {_totalPrice:0.00} zł",
            "Sukces!", MessageBoxButton.OK, MessageBoxImage.Information);

        foreach (Seat seat in _seats)
        {
            if (seat.CurrentOccupation == Seat.Occupation.Selected)
                seat.SetOccupation(Seat.Occupation.Occupied);
        }

        CalculatePrice();
    }
}