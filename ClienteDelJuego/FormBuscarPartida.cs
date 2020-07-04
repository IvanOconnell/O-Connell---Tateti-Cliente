using ClienteDelJuego.Modelo;

using System.Windows.Forms;

namespace ClienteDelJuego
{
    public partial class FormBuscarPartida : Form
    {

        ConexionSocketServer c1;
        Usuario u1;
        public FormBuscarPartida(Usuario u1, ConexionSocketServer c1)
        {
            InitializeComponent();
            this.u1 = u1;
            this.c1 = c1;
        }
       
        
        private void buttonCancelar_Click(object sender, System.EventArgs e)
        {
           c1.salirDeLaCola(u1);
           c1.enviarMensaje("d");
            
            this.Hide();
        }

       
    }
}
