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
using System.Net.Http;
using System.Net.Http.Json;

namespace AIShutUp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
   
   //Redskap för att kommunicera över http
   HttpClient klient = new HttpClient();
   string url = "http'://10.151.168.5:11434/api/generate";
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickSkicka(object sender, RoutedEventArgs e)
    {
        //Läsa av promptexten i ruitan
        string prompt = txbPrompt.Text;

        // Skapa ett json objekt
        object data = new
        {
            model = "phi4:latest",
            prompt = prompt,
            max_tokens = 50
        };

        // Skicka till ollama-ai-servern
        SkickaTillOllama(data);
    }

    public void SkickaTillOllama(object data)
    {
       try
       {
         // Skicka data till servern
        HttpResponseMessage svar = klient.PostAsJsonAsync(url, data).Result;

        // Kontrollera att "requesten" lyckades¨
        svar.EnsureSuccessStatusCode();

        //Läs innehållet i svaret 
        string råtext = svar.Content.ReadAsStringAsync().Result;

        //Skriv ut i svars rutan
        txbSvar.Text = råtext; 
       }
       catch (HttpRequestException e)
       {
        txbSvar.Text = $"Fel: {e.Message}";
       }
    }
}