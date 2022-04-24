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
using System.Windows.Shapes;

namespace Carrowdf
{
    /// <summary>
    /// Lógica de interacción para conducir_carro.xaml
    /// </summary>
    public partial class conducir_carro : Window
    {
        Carrito1 carrito;
        
        public conducir_carro(Carrito1 _tempcarr)
        {
            InitializeComponent();
            carrito = _tempcarr;
            datos.Content = $"Marca: {carrito.marca} Propietario: {carrito.owner} Modelo: {carrito.modelo} Maxima Velocidad: {carrito.maxvelocidad}";
            
        }

        private void acelerar_carro_Click(object sender, RoutedEventArgs e)
        {        
            lblvelocidad.Content = carrito.acelerar();
            
            
        }

        private void encendido_Click(object sender, RoutedEventArgs e)
        {
            
            lblestatus.Content = carrito.encender_motor();
        }

        private void btfrenar_Click(object sender, RoutedEventArgs e)
        {
            lblfrenar.Content = carrito.frenar();
        }

        private void btbocinar_Click(object sender, RoutedEventArgs e)
        {
            lblbocina.Content = carrito.bocinar();
        }

        private void apagado_Click(object sender, RoutedEventArgs e)
        {
            lblapa.Content = carrito.apagar_motor();
        }

        private void desacelerar_Click(object sender, RoutedEventArgs e)
        {
            lbldesa.Content = carrito.desacelerar();
        }
    }
}
