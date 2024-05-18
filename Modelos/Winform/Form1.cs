using System;
using System.Windows.Forms;
using Winform.ServiceReference1;

namespace Winform
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        WebService1SoapClient servicioConsulta = new WebService1SoapClient();

        //En un mundo ideal, toma el id del usuario logueado
        int idUsuarioLogueado = 1;

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            ActualizarLabels();

        }

        private void ActualizarLabels()
        {
            double respuesta = servicioConsulta.CalcularEspacioTotal(idUsuarioLogueado);

            labelTamañoBuzon.Text = "Tamaño de buzon: " + respuesta + " MB";

            respuesta = servicioConsulta.CalcularEspacioDisponible(idUsuarioLogueado);

            labelEspacioDisponible.Text = "Espacio disponible: " + respuesta + " MB";
        }

        private void botonEnviar_Click(object sender, EventArgs e)
        {
            int idDestinatario = int.Parse(textBoxDestinatario.Text);
            string textoMensaje = textBoxMensaje.Text;
            double peso = double.Parse(textBoxPeso.Text);

            Mensaje mensajeParaAgregar = new Mensaje { Id = 3, IdRemitente = idUsuarioLogueado, Contenido = textoMensaje, Tamaño = peso };

            bool respuesta = servicioConsulta.AgregarMensaje(idDestinatario, mensajeParaAgregar);

            if (respuesta)
            {
                MessageBox.Show("El mensaje se envio correctamente");
            }
            else
            {
                MessageBox.Show("El mensaje no se pudo entregar. El peso supera el espacio disponible del destinatario");
            }
        }
    }
}
