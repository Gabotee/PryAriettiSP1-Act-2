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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void cmdRegistrarCliente_Click(object sender, EventArgs e)
        {
            bool BanderaClientes = false;

            //Crea un Archivo.... El true es para q no se sobreescriba el archivo 
            StreamWriter swClientes = new StreamWriter("./Clientes.text",true);
            //Pasa lo que se escribe en las textbox al Archivo 
            swClientes.WriteLine(txtClienteID.Text + " " + txtNombreCliente.Text);
            //Cierra el archivo 
            swClientes.Close();
            //Lee el Archivo 
            StreamReader srClientes = new StreamReader("./Clientes.text");

            char VarSeparador = Convert.ToChar(",");
            
            while (!srClientes.EndOfStream)
            {
                //Se crea vector para guardar lo que tiene el archivo dentro 
                string[] VecClientes = srClientes.ReadLine().Split(VarSeparador);

                //Si es igual No se guardan los datos, porque ya esta registrado 
                if (txtClienteID.Text == VecClientes[0])
                {
                    BanderaClientes = true;
                    MessageBox.Show("El ID ya se encuentra registrado, intente con otro");
                    txtClienteID.Text = "";
                    txtClienteID.Focus();
                }
            }

            srClientes.Close();

            if (BanderaClientes == false)
            {
                StreamWriter swGrabar = new StreamWriter("./Clientes.text");

                swGrabar.WriteLine(txtClienteID.Text + "," + txtNombreCliente.Text);

                swGrabar.Close();

                MessageBox.Show("Los Datos se registraron Correctamente");

                txtClienteID.Text = "";

                txtNombreCliente.Text = "";

                txtClienteID.Focus();

            }

            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cmdRegistrarVendedor_Click(object sender, EventArgs e)
        {
            // file.exist(Ruta).. para ver si existe un archivo
            // file create.. crea un archivo 
            //subtring lee desde la posicion inicial hasta la q se le indique (0,3)..
            //split separa... separar por le caracter (",")...  


            bool BanderaVendedor = false;

            StreamWriter swVendedor = new StreamWriter("./Vendedor.text", true);

            swVendedor.WriteLine(txtVendedorID.Text + " " + txtNombreVendedor.Text);

            swVendedor.Close();

            StreamReader srVendedor = new StreamReader("./Vendedor.text");

            char VarSeparadorVendedor = Convert.ToChar(",");

            while (!srVendedor.EndOfStream)
            {
                string[] VecVendedor = srVendedor.ReadLine().Split(VarSeparadorVendedor);
                if (txtVendedorID.Text == VecVendedor[0])
                {
                    BanderaVendedor = true;
                    MessageBox.Show("El ID ya se encuentra registrado, Intente con otro ");
                    txtVendedorID.Text = "";
                    txtVendedorID.Focus();
                }
            }

            srVendedor.Close();

            if (BanderaVendedor == false)
            {
                StreamWriter swGrabar = new StreamWriter("./Vendedor.text");
                swGrabar.WriteLine(txtVendedorID.Text + "," + txtNombreVendedor.Text);
                swGrabar.Close();
                MessageBox.Show("Los datos se guardaron correctamente");
                txtVendedorID.Text = "";
                txtNombreVendedor.Text = "";
                txtVendedorActivo.Text = "";
                txtComisionVendedor.Text = "";
                txtVendedorID.Focus();
            }

        }

        private void cmdRegistrarVentas_Click(object sender, EventArgs e)
        {
            StreamReader srVendedorID = new StreamReader("./Vendedor.text");

            while (!srVendedorID.EndOfStream)
            {
                string InformacionVendedor = srVendedorID.ReadLine();
                lstVendedorID.Items.Add(InformacionVendedor.Substring(0,2));
            }

            srVendedorID.Close();
        }
    }
}
