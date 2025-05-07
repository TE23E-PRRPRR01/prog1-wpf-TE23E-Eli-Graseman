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

namespace Kontaktboken;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }


    private void KlickVisa(object sender, RoutedEventArgs e)
    {

        string titel = txbTitel.Text;
        string förnamn = txbFornamn.Text;
        string efternamn = txbEfternamn.Text;
        string ålder = txbÅlder.Text;

        if (titel != "Herr" && titel != "Fru")
        {
            txbResultat.Text = $"Felaktig titel! Vänligen ange Herr eller Fru.";
        }
        else
        {
            if (int.TryParse(ålder, out int gammal))
            {
                string resultat = $"Titel:{titel}\nFörnamn:{förnamn}\nEfternamn:{efternamn}\nÅlder:{ålder}\n";

                txbResultat.Text = resultat;
            }
            else
            {
                txbResultat.Text = $"Ålder saknas eller är felaktigt angivet";
            }

        }
    }
}