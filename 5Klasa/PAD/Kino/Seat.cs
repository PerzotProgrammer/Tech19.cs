using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Kino;

public class Seat
{
    public enum Occupation
    {
        Empty,
        Selected,
        Occupied
    }

    public Rectangle Rectangle { get; init; }

    public Occupation CurrentOccupation { get; private set; }

    public Seat(Occupation occupation, int row, int column)
    {
        Rectangle = new Rectangle();

        Rectangle.Margin = new Thickness(2.5);
        Rectangle.SetValue(Grid.RowProperty, row);
        Rectangle.SetValue(Grid.ColumnProperty, column);
        SetOccupation(occupation);

        Rectangle.MouseDown += OnRectangleOnMouseDown;
        Rectangle.MouseEnter += OnRectangleOnMouseEnter;
        Rectangle.MouseLeave += RectangleOnMouseLeave;
    }

    private void RectangleOnMouseLeave(object sender, MouseEventArgs e) => (sender as Rectangle)?.Fill.Opacity = 1;

    private void OnRectangleOnMouseEnter(object sender, MouseEventArgs e) => (sender as Rectangle)?.Fill.Opacity = 0.7;

    private void OnRectangleOnMouseDown(object sender, MouseButtonEventArgs args)
    {
        if (CurrentOccupation != Occupation.Occupied)
        {
            if (CurrentOccupation == Occupation.Empty)
                SetOccupation(Occupation.Selected);
            else if (CurrentOccupation == Occupation.Selected)
                SetOccupation(Occupation.Empty);
            OnRectangleOnMouseEnter(sender, args);
        }
    }

    public void SetOccupation(Occupation occupation)
    {
        Rectangle.Fill = occupation switch
        {
            Occupation.Empty => new SolidColorBrush(Color.FromRgb(0x81, 0xc7, 0x84)),
            Occupation.Selected => new SolidColorBrush(Color.FromRgb(0xff, 0xb3, 0x00)),
            Occupation.Occupied => new SolidColorBrush(Color.FromRgb(0x9e, 0x9e, 0x9e)),
            _ => Rectangle.Fill
        };

        CurrentOccupation = occupation;
    }
}