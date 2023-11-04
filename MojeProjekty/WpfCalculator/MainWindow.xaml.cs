using System;
using System.Data;
using System.Windows;
using System.Windows.Input;


namespace WpfCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        string aktWynik = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void mouseClick(object sender, MouseEventArgs e)
        {
            // POBIERANIE AKUTALNEGO ELEMENTU

            string? elementName = null;
            var mouseWasDownOn = e.Source as FrameworkElement;
            if (mouseWasDownOn != null && mouseWasDownOn.Name != "textBlock")
            {
                elementName = mouseWasDownOn.Name;
                textBlock.Text = elementName;
            }

            // LOGIKA PRZYCISKÓW

            switch (elementName)
            {
                case "b0":
                    aktWynik += "0";
                    textBlock.Text = aktWynik;
                    break;

                case "b1":
                    aktWynik += "1";
                    textBlock.Text = aktWynik;
                    break;

                case "b2":
                    aktWynik += "2";
                    textBlock.Text = aktWynik;
                    break;

                case "b3":
                    aktWynik += "3";
                    textBlock.Text = aktWynik;
                    break;

                case "b4":
                    aktWynik += "4";
                    textBlock.Text = aktWynik;
                    break;

                case "b5":
                    aktWynik += "5";
                    textBlock.Text = aktWynik;
                    break;

                case "b6":
                    aktWynik += "6";
                    textBlock.Text = aktWynik;
                    break;

                case "b7":
                    aktWynik += "7";
                    textBlock.Text = aktWynik;
                    break;

                case "b8":
                    aktWynik += "8";
                    textBlock.Text = aktWynik;
                    break;

                case "b9":
                    aktWynik += "9";
                    textBlock.Text = aktWynik;
                    break;

                case "bc":
                    aktWynik += ".";
                    textBlock.Text = aktWynik;
                    break;

                // DZIAŁANIA

                case "bd":
                    aktWynik += "+";
                    textBlock.Text = aktWynik;
                    break;

                case "bo":
                    aktWynik += "-";
                    textBlock.Text = aktWynik;
                    break;

                case "bpo":
                    aktWynik += "*";
                    textBlock.Text = aktWynik;
                    break;

                case "bpd":
                    aktWynik += "/";
                    textBlock.Text = aktWynik;
                    break;

                // EWALUACJA

                case "bwy":
                    if (aktWynik == "")
                    {
                        textBlock.Text = "0";
                    }
                    else
                    {
                        try
                        {
                            DataTable dt = new();
                            var v = dt.Compute(aktWynik, "");
                            string? output = v.ToString();
                            if (output == "NaN" || output == "\u221E") throw new DivideByZeroException();
                            textBlock.Text = output;
                        }
                        catch (DivideByZeroException)
                        {
                            textBlock.Text = "NIE MOŻNA DZIELIĆ PRZEZ 0!";
                        }
                        catch (Exception)
                        {
                            textBlock.Text = "NIE POPRAWNE DZIAŁANIE";
                        }
                        finally
                        { 
                            aktWynik = "";
                        }
                    }

                    break;
            }
        }
    }
}