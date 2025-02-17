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

namespace melloapp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
        int antalRöd = 0;
        int antalBlå = 0;
        int antalGrön = 0;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickRösta(object sender, RoutedEvent e)
    {
        if (sender == röd)
        {
            antalRöd++;
        }
        else if (sender == blå)
        {
            antalBlå++;
        }
        else if (sender == grön)
        {
            antalGrön++;
        }

        // För varje klick +1
        tbxResultat.Text = $"Röd: {antalRöd}";
    }
}