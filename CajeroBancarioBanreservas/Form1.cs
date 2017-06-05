using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroBancarioBanreservas
{
    public partial class Form1 : Form
    {

        //public void variables (){ tbxTarjeta.Text = ""; tbxPIN.Text = ""; }
        string tajetaUsuario = "44445555";
        string pin = "2030";
        double balanceUsuario = 11000;
        public Form1()
        {
            InitializeComponent();
            

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbxTarjeta.Text = tbxTarjeta.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbxTarjeta.Text = tbxTarjeta.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbxTarjeta.Text = tbxTarjeta.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbxTarjeta.Text = tbxTarjeta.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbxTarjeta.Text = tbxTarjeta.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbxTarjeta.Text = tbxTarjeta.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbxTarjeta.Text = tbxTarjeta.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbxTarjeta.Text = tbxTarjeta.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbxTarjeta.Text = tbxTarjeta.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tbxTarjeta.Text = tbxTarjeta.Text + "0";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            tbxTarjeta.Text = tbxTarjeta.Text.Substring(0, tbxTarjeta.Text.Length - 1);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string tarjeta = "44445555";

            Properties.Settings.Default.tarjeta = tarjeta;

            if(tbxTarjeta.Text == Properties.Settings.Default.tarjeta) {

                tabControl1.SelectTab(1);

            }
            else {

                MessageBox.Show("La contraseña que acabas de insertar es incorrecta.");

            }

            Console.Beep(600, 500);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxTarjeta_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            tbxPIN.Text = tbxPIN.Text + "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            tbxPIN.Text = tbxPIN.Text + "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            tbxPIN.Text = tbxPIN.Text + "3";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            tbxPIN.Text = tbxPIN.Text + "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            tbxPIN.Text = tbxPIN.Text + "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            tbxPIN.Text = tbxPIN.Text + "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            tbxPIN.Text = tbxPIN.Text + "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            tbxPIN.Text = tbxPIN.Text + "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            tbxPIN.Text = tbxPIN.Text + "9";
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            tbxPIN.Text = tbxPIN.Text + "0";
        }

        private void btnBorrar2_Click(object sender, EventArgs e)
        {
            tbxPIN.Text = tbxPIN.Text.Substring(0, tbxPIN.Text.Length - 1);
        }

        private void btnAceptar2_Click(object sender, EventArgs e)
        {
            string pinTarjeta = "2030";
            Properties.Settings.Default.pin = pinTarjeta;

            if (tbxPIN.Text == Properties.Settings.Default.pin)
            {
                tabControl1.SelectTab(2);
            }
            else {

            }

        }

        private void btnCancelar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            string balance = "10000";
            Properties.Settings.Default.balance = balance;
            tabControl1.SelectTab(3);
        }

        private void btnVerBalanc_Click(object sender, EventArgs e)
        {
            string nombreUsuario = "Amadiz Suares";
            Properties.Settings.Default.nombre = nombreUsuario;

            MessageBox.Show(Properties.Settings.Default.nombre + " su saldo actual es de " + Properties.Settings.Default.balance);
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
        }

        private void btn100_Click(object sender, EventArgs e)
        {
           
            Properties.Settings.Default.retiro = 100;
            balanceUsuario -= Properties.Settings.Default.retiro;

            MessageBox.Show(Properties.Settings.Default.nombre + " altualmente te quedan " + balanceUsuario);

        }

        private void btn200_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.retiro = 200;
            balanceUsuario -= Properties.Settings.Default.retiro;

            MessageBox.Show(Properties.Settings.Default.nombre + " altualmente te quedan " + balanceUsuario);
        }

        private void btn300_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.retiro = 300;
            balanceUsuario -= Properties.Settings.Default.retiro;

            MessageBox.Show(Properties.Settings.Default.nombre + " altualmente te quedan " + balanceUsuario);
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.retiro = 500;
            balanceUsuario -= Properties.Settings.Default.retiro;

            MessageBox.Show(Properties.Settings.Default.nombre + " altualmente te quedan " + balanceUsuario);

        }

        private void btnMil_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.retiro = 1000;
            balanceUsuario -= Properties.Settings.Default.retiro;

            MessageBox.Show(Properties.Settings.Default.nombre + " altualmente te quedan " + balanceUsuario);

        }

        private void btnDMil_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.retiro = 2000;
            balanceUsuario -= Properties.Settings.Default.retiro;

            MessageBox.Show(Properties.Settings.Default.nombre + " altualmente te quedan " + balanceUsuario);
        }

        private void btnOtra_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.retiro = 10000;
            balanceUsuario -= Properties.Settings.Default.retiro;

            MessageBox.Show(Properties.Settings.Default.nombre + " altualmente te quedan " + balanceUsuario);
            //tabControl1.SelectTab(5);

        }

        private void btnAtrasR_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void btnAtrasBalanc_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }


    }
}
