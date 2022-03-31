using MonCine.Data;
using System.Windows;
using System.Windows.Controls;

namespace MonCine.Vues
{
    /// <summary>
    /// Logique d'interaction pour Accueil.xaml
    /// </summary>
    public partial class Accueil : Page
    {
        private DAL dal;
        public Accueil()
        {
            InitializeComponent();
            dal = new DAL();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FAbonnes frmAbonnes = new FAbonnes(dal);

            this.NavigationService.Navigate(frmAbonnes);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FProjections frmProjections = new FProjections();

            this.NavigationService.Navigate(frmProjections);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FFilms frmFilms = new FFilms();

            this.NavigationService.Navigate(frmFilms);
        }
    }
}
