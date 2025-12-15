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

namespace mozi
{
    public class Mozi
    {
        public string Cim { get; set; }

        public DateTime Időpont { get; set; }

        public string Terem { get; set; }

        public int Szabadhelyek { get; set; }

        public bool _3D { get; set; }

        public Mozi(string cim, DateTime időpont, string terem, int szabadhelyek, bool _3D)
        {
            Cim = cim;
            Időpont = időpont;
            Terem = terem;
            Szabadhelyek = szabadhelyek;
            this._3D = _3D;
        }
    }
    public partial class MainWindow : Window
    {
        public List<Mozi> mozifilmek = new List<Mozi>();

        public MainWindow()
        {
            InitializeComponent();
            mozifilmek.Add(new Mozi("Gyűrűk Ura", new DateTime(2025, 12, 15), "1-es terem", 12, true));
            mozifilmek.Add(new Mozi("Nagyfiúk 2", new DateTime(2025, 11, 10), "3-es terem", 12, true));
            mozifilmek.Add(new Mozi("Shamless", new DateTime(2025, 10, 11), "4-es terem", 12, true));
            mozifilmek.Add(new Mozi("Venom", new DateTime(2025, 12, 08), "5-es terem", 12, true));
            mozifilmek.Add(new Mozi("Spider-Man", new DateTime(2025, 11, 10), "2-es terem", 12, true));
            datagrid.ItemsSource = mozifilmek;
        }
        private void adatokbetoltese(object sender, RoutedEventArgs e)
        {
            datagrid.ItemsSource = mozifilmek;
        }
        private void foglalás(object sender, RoutedEventArgs e)
        {
            if (datagrid.SelectedItems is Mozi)
            {
                ((Mozi)datagrid.SelectedItem).Szabadhelyek
                    = ((Mozi)datagrid.SelectedItem).Szabadhelyek - 1;
                datagrid.Items.Refresh();
            }
        }
    }
}
