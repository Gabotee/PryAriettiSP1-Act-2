using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryAriettiSP1_Act_2
{
    public partial class FrmConsultar : Form
    {
        public FrmConsultar()
        {
            InitializeComponent();
        }

        private void cmdListarVentas_Click(object sender, EventArgs e)
        {
            //En Esta Parte del codigo se muestran los datos del archivo en una Grilla.

             StreamReader srLeer = new StreamReader("./Ventas.text");

             char VarSeparador = Convert.ToChar(" ");

            dgvConsulta.Rows.Clear();

            while (!srLeer.EndOfStream)
            {
                string[] VecVentas = srLeer.ReadLine().Split(VarSeparador);
                dgvConsulta.Rows.Add(VecVentas);
            }

            srLeer.Close();
          
        }
    }
}
