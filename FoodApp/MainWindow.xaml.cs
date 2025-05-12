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

namespace FoodApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    List<string> receptLista = [];

    private void KlickVisa(object sender, RoutedEventArgs e)
    {
        string namn = txbNamn.Text;
        string ingrediens = txbIngrediens.Text;
        string tid = txbTid.Text;

        if (ingrediens != "kött" && ingrediens != "fisk")
        {
            txbResultat.Text = $"Namn:{namn}\nIngrediens:{ingrediens}\nTid:{tid}\nOBS! Ovanlig ingrediens";
        }
        if (namn == "" && ingrediens == "")
        {
            txbResultat.Text = "Fyll i både namn och tid.";
        }
        if (int.TryParse(tid, out int tiden))
        {
            if (tiden <= 15)
            {
                txbResultat.Text = $"Namn:{namn}\nIngrediens:{ingrediens}\nTid:{tid}\nOvanligt snabbt recept";
            }
            if (tiden >= 45)
            {
                txbResultat.Text = $"Namn:{namn}\nIngrediens:{ingrediens}\nTid:{tid}\nOvanligt långsamt recept";
            }
            else
            {
                txbResultat.Text = $"Namn:{namn}\nIngrediens:{ingrediens}\nTid:{tid}\n";
            }
        }
        else
        {
            txbResultat.Text = $"Namn:{namn}\nIngrediens:{ingrediens}\nTid:{tid}\n";
        }
    }

    private void KlickRensa(object sender, RoutedEventArgs e)
    {

    }

    private void KlickSpara(object sender, RoutedEventArgs e)
    {
        receptLista.Add(txbResultat.Text);
    }





}