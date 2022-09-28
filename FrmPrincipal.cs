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

            //Este codigo registra Los datos del cliente 

            bool BanderaClientes = false;

            //Crea un Archivo.... El true es para q no se sobreescriba el archivo 
            StreamWriter swClientes = new StreamWriter("./Clientes.text",true);
         
            //Cierra el archivo 
            swClientes.Close();

            //Lee el Archivo 
            StreamReader srClientes = new StreamReader("./Clientes.text");

            // Se crea Variable para separar 
            char VarSeparador = Convert.ToChar(" ");
            
            while (!srClientes.EndOfStream)
            {
                //Se guarda en el vector los datos del archivo 
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
                StreamWriter swGrabar = new StreamWriter("./Clientes.text", true);

                swGrabar.WriteLine(txtClienteID.Text + " " +  txtNombreCliente.Text);

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
            //split separa... separar por el caracter (",")...  


            
            bool BanderaVendedor = false;

            // Aca se creo el archivo Vendedor.. 
            StreamWriter swVendedor = new StreamWriter("./Vendedor.text", true);
            // Se cierra el Archivo
            swVendedor.Close();
            // Se lee el Archivo 
            StreamReader srVendedor = new StreamReader("./Vendedor.text");
            // Se crea Variable para separar 
            char VarSeparadorVendedor = Convert.ToChar(" ");
            // Mientras sea diferente de fin de archivo  
            while (!srVendedor.EndOfStream)
            {
                // Se le pasa a un vector los datos del archivo 
                string[] VecVendedor = srVendedor.ReadLine().Split(VarSeparadorVendedor);
                // Si el dato ya esta en el vector se toma como repetido 
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
                StreamWriter swGrabar = new StreamWriter("./Vendedor.text", true);
                swGrabar.WriteLine(txtVendedorID.Text + " " + txtNombreVendedor.Text);
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
            //Cargar las ventas al archivo 

            StreamWriter SwVentas = new StreamWriter("./Ventas.text", true);

            SwVentas.WriteLine(txtTipoFactura.Text + " " + txtNumeroFactura.Text + " " + lstClienteID.Text + " " + lstVendedorID.Text + " " + txtMonto.Text + " " + dtpFecha.Text);

            SwVentas.Close();

            MessageBox.Show("Venta Cargada Exitosamente");

            txtTipoFactura.Text = "";
            txtNumeroFactura.Text = "";
            lstClienteID.SelectedIndex = -1;
            lstVendedorID.SelectedIndex = -1;
            txtMonto.Text = "";
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void lstClienteID_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void tabVentas_SelectedIndexChanged(object sender, EventArgs e)
        {
           //Este codigo es para mostrar la ID del cliente y del vendedor en las listas desplegables 
           //de la ventana Ventas.

            //Limpiar las listas desplegables 
            lstClienteID.Items.Clear();
            lstVendedorID.Items.Clear();

            StreamWriter Cliente = new StreamWriter("./Clientes.text", true);
            Cliente.Close();
            StreamWriter Vendedor = new StreamWriter("./Vendedor.text", true);
            Vendedor.Close();

            StreamReader LeerCliente = new StreamReader("./Clientes.text");

            StreamReader LeerVendedor = new StreamReader("./Vendedor.text");

            char VarSeprarador = Convert.ToChar(" ");

            while (!LeerCliente.EndOfStream)
            {
                string[] VecClientes = LeerCliente.ReadLine().Split(VarSeprarador);

                lstClienteID.Items.Add(VecClientes[0]);
            }

            LeerCliente.Close();

            while (!LeerVendedor.EndOfStream)
            {
                string[] VecVendedor = LeerVendedor.ReadLine().Split(VarSeprarador);

                lstVendedorID.Items.Add(VecVendedor[0]);
            }

            LeerVendedor.Close();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Se crea Ventana Para Consultar 
            FrmConsultar VentanaConsultar = new FrmConsultar();
            VentanaConsultar.ShowDialog();
        }

        private void tabPageVendedor_Click(object sender, EventArgs e)
        {
            
        }
    }
}
