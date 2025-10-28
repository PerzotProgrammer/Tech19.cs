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
using SpokojnySklepUI.products;

namespace SpokojnySklepUI;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private Regex _numberRegex;
    private CartSingleton _cartSingleton;

    public MainWindow()
    {
        _cartSingleton = CartSingleton.GetInstance();
        _numberRegex = new Regex("[^0-9]+");
        InitializeComponent();
    }

    private void PriceOfProduct_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
    {
        e.Handled = _numberRegex.IsMatch(e.Text);
    }

    private void DiscountValue_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
    {
        e.Handled = _numberRegex.IsMatch(e.Text);
    }

    private void CalculatePriceButton_OnClick(object sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void PreviousItemButton_OnClick(object sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void NextItemButton_OnClick(object sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void MainWindow_OnKeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.A && Keyboard.Modifiers.HasFlag(ModifierKeys.Control))
        {
            if (!uint.TryParse(PriceOfProduct.Text, out uint price))
            {
                MessageBox.Show("Nieprawidłowa cena!!!");
                return;
            }

            if (NameOfProduct.Text.Trim() == "")
            {
                MessageBox.Show("Nazwa produktu jest pusta!!!");
            }

            _cartSingleton.AddToCart(new PhysicalProduct((int)price, NameOfProduct.Text.Trim()));
            RefreshProductUI();
        }
    }

    private void RefreshProductUI()
    {
        Product product = _cartSingleton.GetLastElementInCart();

        PriceOfProduct.Text = product.GetPrice().ToString();
        NameOfProduct.Text = product.GetName();
    }
}