using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Carrowdf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Carrito1 carr;

        public MainWindow()
        {
            InitializeComponent();
           
            
        }

        private void crear_carro_Click(object sender, RoutedEventArgs e)
        {
            string mar = combo_box_marca.Text;
            int maxvel = Convert.ToInt32(txtmax_vel.Text);
            string propietario = txtpropietario.Text;
            int modl = Convert.ToInt32(txtmodelo.Text);

            carr = new Carrito1 (mar,modl,maxvel,propietario);

            conducir_carro otroMainWindow = new conducir_carro(carr);
            otroMainWindow.Show();
           
        }
    }
}
