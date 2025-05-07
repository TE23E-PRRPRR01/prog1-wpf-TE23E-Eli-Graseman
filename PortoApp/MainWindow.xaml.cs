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

namespace PortoApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ClickBeräknaPorto(object sender, RoutedEventArgs e)
    {
        //Läs in vikten
        string input = txbVikt.Text;

        //Gör om till ett tal
        int vikt = int.Parse(input);
        if (vikt <=50)
        {
            LblResultat.Content = "Ditt porto kostar 22kr";
        }
        else if (vikt <=100)
        {
            LblResultat.Content = " Ditt porto kostar 44kr";
        }
          else if (vikt <=250)
        {
            LblResultat.Content = "Ditt porto kostar 66kr";
        }
          else if (vikt <=500)
        {
            LblResultat.Content = "Ditt porto kostar 88kr";
        }
          else if (vikt <=1000)
        {
            LblResultat.Content = "Ditt porto kostar 132kr";
        }
          else if (vikt <=2000)
        {
            LblResultat.Content = "Ditt porto kostar 154kr";
        }
    }
}