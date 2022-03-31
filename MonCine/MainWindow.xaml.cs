using MonCine.Vues;
using System.Windows;

namespace MonCine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _NavigationFrame.Navigate(new Accueil());
        }
    }
}
