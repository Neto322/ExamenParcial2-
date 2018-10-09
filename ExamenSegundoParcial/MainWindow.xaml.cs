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

namespace ExamenSegundoParcial
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int contador = 0;
        public MainWindow()
        {

            InitializeComponent();
            ControlInformacionPersonal.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

              if(contador == 0)
            {
                if (String.IsNullOrEmpty(ControlInformacionPersonal.Nombre.Text) || String.IsNullOrEmpty(ControlInformacionPersonal.ApellidoMaterno.Text) || String.IsNullOrEmpty(ControlInformacionPersonal.ApellidoPaterno.Text) || String.IsNullOrEmpty(ControlInformacionPersonal.Edad.Text))
                {
                    Error.Text = "Es necesario llenar todos los datos";
                }
                else
                {
                    Error.Text = "";
                    ControlInformacionPersonal.Visibility = Visibility.Collapsed;
                    ControlContacto.Visibility = Visibility.Visible;
                    contador++;
                }
            }
 
            if (contador == 1)
            {
                if (String.IsNullOrEmpty(ControlContacto.CoRREO.Text) || String.IsNullOrEmpty(ControlContacto.Celular.Text) || String.IsNullOrEmpty(ControlContacto.Celular.Text) || String.IsNullOrEmpty(ControlContacto.Telefono.Text))
                {
                    Error.Text = "Es necesario llenar todos los datos";
                }
                else
                {
                    ControlContacto.Visibility = Visibility.Collapsed;
                    ControlInformacionPago.Visibility = Visibility.Visible;
                    Error.Text = "";
                    contador++;
                }
            }
   
            if (contador == 2)
            {
                if (String.IsNullOrEmpty(ControlInformacionPago.Tarjeta.Text) || String.IsNullOrEmpty(ControlInformacionPago.CVV.Text) || String.IsNullOrEmpty(ControlInformacionPago.Expiracion.Text) || String.IsNullOrEmpty(ControlInformacionPago.Año.Text))
                {
                    Error.Text = "Es necesario llenar todos los datos";
                }
                else if (ControlInformacionPago.Tarjeta.Text.Length == 16)
                {
                    ControlInformacionPago.Visibility = Visibility.Collapsed;
                    Error.Text = "";
                }
                else
                {
                    Error.Text = "La tarjeta debe tener 16 digitos";
                }
            }
   
          
            }

       
             
                
            
            
        }
    }

