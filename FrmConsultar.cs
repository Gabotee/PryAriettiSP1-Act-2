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
            //En Esta Parte del codigo se muestra lo del archivo en una Grilla 

            dgvConsulta.Rows.Clear();


            StreamReader srLeer = new StreamReader("./Ventas.text");

            while (!srLeer.EndOfStream)
            {
                string LeerVentas = srLeer.ReadLine();
                string[] VecVentas = LeerVentas.Split('.');
                dgvConsulta.Rows.Add(VecVentas[2], VecVentas[3], VecVentas[4], VecVentas[1], VecVentas[0], VecVentas[5]);
            }

            srLeer.Close();
        }
    }
}
