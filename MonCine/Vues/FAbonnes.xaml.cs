using MonCine.Data;
using System.Collections.Generic;
using System.Windows.Controls;

namespace MonCine.Vues
{
    /// <summary>
    /// Logique d'interaction pour FAbonnes.xaml
    /// </summary>
    public partial class FAbonnes : Page
    {
        private List<Abonne> abonnes;
        public FAbonnes(DAL dal)
        {
            InitializeComponent();
            abonnes = dal.ReadAbonnes();
        }
    }
}
