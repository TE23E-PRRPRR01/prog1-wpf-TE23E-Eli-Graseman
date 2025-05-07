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

namespace Bran;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
     int poängInne = 0;
        int poängUte= 0;
    public MainWindow()
    {
        InitializeComponent();

        
    }

    private void KlickFrivarv(object sender, RoutedEventArgs e)
    {
    

        poängInne +=5;

        tbxInne.Text = $"{poängInne}";

    }

private void KlickBränning(object sender, RoutedEventArgs e)
    {
    

        poängUte +=12;

        tbxUte.Text = $"{poängUte}";

    }
private void KlickLyra(object sender, RoutedEventArgs e)
    {
    

        poängUte +=3;

        tbxUte.Text = $"{poängUte}";

    }
private void KlickVarv(object sender, RoutedEventArgs e)
    {
    

        poängInne +=5;

        tbxInne.Text = $"{poängInne}";

    }


}